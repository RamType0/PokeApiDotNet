using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public interface IApiResource
{
    public abstract static string EndpointPath { get; }
    public abstract static string CreatePageUrl(ReadOnlySpan<char> apiV2Endpoint, int offset, int limit);
    public abstract static string CreateUrl(ReadOnlySpan<char> apiV2Endpoint, int id);
    public abstract string GetUrlWithId(ReadOnlySpan<char> apiV2Endpoint);
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public abstract int Id { get; init; }
}
public interface IApiResource<TSelf> : IApiResource
    where TSelf : IApiResource<TSelf>
{
    static string IApiResource.CreatePageUrl(ReadOnlySpan<char> apiV2Endpoint, int offset, int limit) => $"{apiV2Endpoint}{TSelf.EndpointPath}/?offset={offset}&limit={limit}";
    static string IApiResource.CreateUrl(ReadOnlySpan<char> apiV2Endpoint, int id) => $"{apiV2Endpoint}{TSelf.EndpointPath}/{id}/";
    string IApiResource.GetUrlWithId(ReadOnlySpan<char> apiV2Endpoint) => $"{apiV2Endpoint}{TSelf.EndpointPath}/{Id}/";

}