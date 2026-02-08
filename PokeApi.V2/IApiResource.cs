using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public interface IApiResource
{
    public abstract static string EndpointPath { get; }
    public abstract static string CreatePageUrl(int offset, int limit);
    public abstract static string CreateUrl(int id);
    public abstract string GetUrlWithId();
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
    static string IApiResource.CreatePageUrl(int offset, int limit) => $"{PokeApiClient.ApiEndpoint}{TSelf.EndpointPath}/?offset={offset}&limit={limit}";
    static string IApiResource.CreateUrl(int id) => $"{PokeApiClient.ApiEndpoint}{TSelf.EndpointPath}/{id}/";
    string IApiResource.GetUrlWithId() => $"{PokeApiClient.ApiEndpoint}{TSelf.EndpointPath}/{Id}/";

}