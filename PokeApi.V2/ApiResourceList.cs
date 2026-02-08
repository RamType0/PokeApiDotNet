using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public abstract record ApiResourceList
{
    /// <summary>
    /// The total number of resources available from this API.
    /// </summary>
    [JsonPropertyName("count")]
    [Description("The total number of resources available from this API.")]
    public required int Count { get; init; }
    /// <summary>
    /// The URL for the next page in the list.
    /// </summary>
    [JsonPropertyName("next")]
    [Description("The URL for the next page in the list.")]
    public Uri? Next { get; init; }
    /// <summary>
    /// The URL for the previous page in the list.
    /// </summary>
    [JsonPropertyName("previous")]
    [Description("The URL for the previous page in the list.")]
    public Uri? Previous { get; init; }
}
public abstract record ApiResourceList<T> : ApiResourceList
    where T : ApiResourceReference
{
    /// <summary>
    /// A list of API resources.
    /// </summary>
    [JsonPropertyName("results")]
    [Description("A list of API resources.")]
    public required ImmutableArray<T> Results { get; init; }
}

public record NamedApiResourceList<T> : ApiResourceList<NamedApiResourceReference<T>> where T : INamedApiResource;
public record UnnamedApiResourceList<T> : ApiResourceList<ApiResourceReference<T>> where T : IApiResource;