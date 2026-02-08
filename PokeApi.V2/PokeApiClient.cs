using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace PokeApi.V2;

public class PokeApiClient: IDisposable
{
    public const string ApiEndpoint = "https://pokeapi.co/api/v2/";

    static JsonSerializerOptions JsonSerializerOptions { get; } = new(JsonSerializerDefaults.Web)
    {
        RespectNullableAnnotations = true,
    };
    HttpClient Http { get; }
    IMemoryCache? MemoryCache { get; }
    IDistributedCache? DistributedCache { get; }
    public PokeApiClient() : this(new HttpClient()) { }
    public PokeApiClient(HttpClient httpClient): this(httpClient, null, null) { }
    public PokeApiClient(IMemoryCache memoryCache) : this(new(), memoryCache) { }
    public PokeApiClient(HttpClient httpClient, IMemoryCache memoryCache) : this(httpClient, memoryCache, null) { }
    public PokeApiClient(IDistributedCache distributedCache) : this(new(), distributedCache) { }
    public PokeApiClient(HttpClient httpClient, IDistributedCache distributedCache) : this(httpClient, null, distributedCache) { }
    public PokeApiClient(HttpClient httpClient, IMemoryCache? memoryCache = null, IDistributedCache? distributedCache = null)
    {
        Http = httpClient;
        MemoryCache = memoryCache;
        DistributedCache = distributedCache;
    }
    public Task<T> GetApiResourceAsync<T>(int id, CancellationToken cancellationToken = default)
        where T : notnull, IApiResource
        => GetAsync<T>(new Uri(T.CreateUrl(id), UriKind.Absolute), cancellationToken);
    public Task<T> GetApiResourceAsync<T>(ReadOnlySpan<char> name, CancellationToken cancellationToken = default)
        where T : notnull, INamedApiResource
        => GetAsync<T>(new Uri(T.CreateUrl(name), UriKind.Absolute), cancellationToken);
    public Task<T> GetApiResourceAsync<T>(ApiResourceReference<T> apiResourceReference, CancellationToken cancellationToken = default)
        where T : notnull, IApiResource
        => GetAsync<T>(apiResourceReference.Url, cancellationToken);
    public Task<T> GetApiResourcePropertyAsync<T>(int id, CancellationToken cancellationToken = default)
        where T: notnull, IApiResourceProperty
        => GetAsync<T>(new(T.CreateUrl(id), UriKind.Absolute), cancellationToken);
    public Task<T> GetApiResourcePropertyAsync<T>(ReadOnlySpan<char> name, CancellationToken cancellationToken = default)
        where T : notnull, INamedApiResourceProperty
        => GetAsync<T>(new(T.CreateUrl(name), UriKind.Absolute), cancellationToken);
    public Task<TProperty> GetApiResourcePropertyAsync<TResource, TProperty>(ApiResourceReference<TResource> apiResourceReference, CancellationToken cancellationToken = default)
        where TResource : notnull, IApiResource
        where TProperty : notnull, IApiResourceProperty<TResource, TProperty>
        => GetAsync<TProperty>(new(TProperty.CreateUrl(apiResourceReference), UriKind.Absolute), cancellationToken);
    public Task<NamedApiResourceList<T>> GetApiResourcePageAsync<T>(int offset = 0, int limit = 20, CancellationToken cancellationToken = default)
        where T : notnull, INamedApiResource
        => GetAsync<NamedApiResourceList<T>>(new(T.CreatePageUrl(offset, limit), UriKind.Absolute), cancellationToken);
    public IAsyncEnumerable<NamedApiResourceReference<T>> EnumerateApiResourcesAsync<T>(int pageSize = 20, CancellationToken cancellationToken = default)
        where T : notnull, INamedApiResource
        => EnumerateApiResourcesAsync<T>(.., pageSize, false, cancellationToken);
    public async IAsyncEnumerable<NamedApiResourceReference<T>> EnumerateApiResourcesAsync<T>(Range range, int pageSize = 20, bool throwOnOutOfRange = false, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        where T : notnull, INamedApiResource
    {
        int offset;
        if(range.Start.IsFromEnd)
        {
            var p = await GetApiResourcePageAsync<T>(0, 1, cancellationToken);
            offset = range.Start.GetOffset(p.Count);
        }
        else
        {
            offset = range.Start.Value;
        }
        var limit = range.End.IsFromEnd ? pageSize : Math.Min(pageSize, range.End.Value - offset);
        while (true)
        {
            var page = await GetApiResourcePageAsync<T>(offset, limit, cancellationToken);
            var end = range.End.GetOffset(page.Count);
            var count = Math.Min(page.Results.Length, end - offset);
            for (int i = 0; i < count; i++)
            {
                yield return page.Results[i];
            }
            offset += count;
            if(offset < end)
            {
                if(page.Next is null)
                {
                    if (throwOnOutOfRange)
                    {
                        throw new ArgumentOutOfRangeException(nameof(range), $"The total number of resources available is {page.Count}, but you requested range of {range}.");
                    }
                    else
                    {
                        break;
                    }
                }
                continue;
            }
            else
            {
                break;
            }
        }
    }
    internal async Task<T> GetAsync<T>(Uri url, CancellationToken cancellationToken = default)
        where T : notnull
    {
        if (MemoryCache?.TryGetValue(url, out T? memoryCachedValue) == true)
        {
            return memoryCachedValue ?? throw new UnreachableException();
        }
        if (DistributedCache is not null)
        {
            var distributedCachedJson = await DistributedCache.GetAsync(url.AbsoluteUri, cancellationToken);
            if (distributedCachedJson is { Length: > 0 })
            {
                var distributedCachedValue = JsonSerializer.Deserialize<T>(distributedCachedJson.AsSpan(), JsonSerializerOptions) ?? throw new UnreachableException();
                SetMemoryCacheIfAvailable(url, distributedCachedValue);
                return distributedCachedValue;
            }
        }
        using var response = await Http.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var apiResource = await response.Content.ReadFromJsonAsync<T>(JsonSerializerOptions, cancellationToken);
        if(apiResource is null) 
        {
            throw new HttpRequestException(HttpRequestError.InvalidResponse);
        }
        SetMemoryCacheIfAvailable(url, apiResource);
        await SetDistributedCacheIfAvailableAsync(url, response, apiResource, cancellationToken);

        return apiResource;
    }
    private void SetMemoryCacheIfAvailable<T>(Uri url, T value)
        where T : notnull
    {
        if (MemoryCache is not null)
        {
            switch (value)
            {
                case INamedApiResource namedApiResource:
                    {
                        MemoryCache.Set(namedApiResource.GetUrlWithId(), value);
                        MemoryCache.Set(namedApiResource.GetUrlWithName(), value);
                    }
                    break;
                case IApiResource apiResource:
                    {

                        MemoryCache.Set(apiResource.GetUrlWithId(), value);
                    }
                    break;
                default:
                    {
                        MemoryCache.Set(url.AbsoluteUri, value);
                    }
                    break;
            }
        }
    }
    private async Task SetDistributedCacheIfAvailableAsync<T>(Uri url, HttpResponseMessage response, T value, CancellationToken cancellationToken) 
        where T: notnull
    {
        if (DistributedCache is not null)
        {
            var bytes = await response.Content.ReadAsByteArrayAsync(cancellationToken);
            switch (value)
            {
                case INamedApiResource namedApiResource:
                    {
                        await DistributedCache.SetAsync(namedApiResource.GetUrlWithId(), bytes, cancellationToken);
                        await DistributedCache.SetAsync(namedApiResource.GetUrlWithName(), bytes, cancellationToken);
                    }
                    break;
                case IApiResource apiResource:
                    {
                        await DistributedCache.SetAsync(apiResource.GetUrlWithId(), bytes, cancellationToken);
                    }
                    break;
                default:
                    {
                        await DistributedCache.SetAsync(url.AbsoluteUri, bytes, cancellationToken);
                    }
                    break;
            }
        }
    }
    public void Dispose() => Http.Dispose();
}

public static class PokeApiClientUnnamedApiResourcePageExtensions
{
    public static Task<UnnamedApiResourceList<T>> GetApiResourcePageAsync<T>(this PokeApiClient client, int offset = 0, int limit = 20, CancellationToken cancellationToken = default)
        where T : notnull, IApiResource
        => client.GetAsync<UnnamedApiResourceList<T>>(new(T.CreatePageUrl(offset, limit), UriKind.Absolute), cancellationToken);
    public static IAsyncEnumerable<ApiResourceReference<T>> EnumerateApiResourcesAsync<T>(this PokeApiClient client, int pageSize = 20, CancellationToken cancellationToken = default)
        where T : notnull, IApiResource
        => client.EnumerateApiResourcesAsync<T>(.., pageSize, false, cancellationToken);
    public static async IAsyncEnumerable<ApiResourceReference<T>> EnumerateApiResourcesAsync<T>(this PokeApiClient client, Range range, int pageSize = 20, bool throwOnOutOfRange = false, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        where T : notnull, IApiResource
    {
        int offset;
        if (range.Start.IsFromEnd)
        {
            var p = await client.GetApiResourcePageAsync<T>(0, 1, cancellationToken);
            offset = range.Start.GetOffset(p.Count);
        }
        else
        {
            offset = range.Start.Value;
        }
        var limit = range.End.IsFromEnd ? pageSize : Math.Min(pageSize, range.End.Value - offset);
        while (true)
        {
            var page = await client.GetApiResourcePageAsync<T>(offset, limit, cancellationToken);
            var end = range.End.GetOffset(page.Count);
            var count = Math.Min(page.Results.Length, end - offset);
            for (int i = 0; i < count; i++)
            {
                yield return page.Results[i];
            }
            offset += count;
            if (offset < end)
            {
                if (page.Next is null)
                {
                    if (throwOnOutOfRange)
                    {
                        throw new ArgumentOutOfRangeException(nameof(range), $"The total number of resources available is {page.Count}, but you requested range of {range}.");
                    }
                    else
                    {
                        break;
                    }
                }
                continue;
            }
            else
            {
                break;
            }
        }
    }

}