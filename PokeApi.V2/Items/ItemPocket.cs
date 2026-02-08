using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemPocket : INamedApiResource<ItemPocket>
{
    public static string EndpointPath => "item-pocket";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }
    /// <summary>
    /// The name for this resource.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The name for this resource.")]
    public required string Name { get; init; }
    /// <summary>
    /// A list of item categories that are relevant to this item pocket.
    /// </summary>
    [JsonPropertyName("categories")]
    [Description("A list of item categories that are relevant to this item pocket.")]
    public required ImmutableArray<NamedApiResourceReference<ItemCategory>> Categories { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
}
