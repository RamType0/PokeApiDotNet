using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public interface INamedApiResource : IApiResource
{
    public abstract static string CreateUrl(ReadOnlySpan<char> apiV2Endpoint, ReadOnlySpan<char> name);
    public abstract string GetUrlWithName(ReadOnlySpan<char> apiV2Endpoint);
    /// <summary>
    /// The name for this resource.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The name for this resource.")]
    public abstract string Name { get; init; }
}
public interface INamedApiResource<TSelf> : INamedApiResource, IApiResource<TSelf>
    where TSelf : notnull, INamedApiResource<TSelf>
{
    private static new string CreateUrl(ReadOnlySpan<char> apiV2Endpoint, ReadOnlySpan<char> name)
    {
        Span<char> buffer = stackalloc char[name.Length];
        var length = name.ToLowerInvariant(buffer);
        var lowerCaseName = buffer[..length];
        return $"{apiV2Endpoint}{TSelf.EndpointPath}/{lowerCaseName}/";
    }
    static string INamedApiResource.CreateUrl(ReadOnlySpan<char> apiV2Endpoint, ReadOnlySpan<char> name) => CreateUrl(apiV2Endpoint, name);

    string INamedApiResource.GetUrlWithName(ReadOnlySpan<char> apiV2Endpoint) => CreateUrl(apiV2Endpoint, Name);
}