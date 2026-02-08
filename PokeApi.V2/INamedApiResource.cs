using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public interface INamedApiResource : IApiResource
{
    public abstract static string CreateUrl(ReadOnlySpan<char> name);
    public abstract string GetUrlWithName();
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
    private static new string CreateUrl(ReadOnlySpan<char> name)
    {
        Span<char> buffer = stackalloc char[name.Length];
        var length = name.ToLowerInvariant(buffer);
        var lowerCaseName = buffer[..length];
        return $"{PokeApiClient.ApiEndpoint}{TSelf.EndpointPath}/{lowerCaseName}/";
    }
    static string INamedApiResource.CreateUrl(ReadOnlySpan<char> name) => CreateUrl(name);

    string INamedApiResource.GetUrlWithName() => CreateUrl(Name);
}