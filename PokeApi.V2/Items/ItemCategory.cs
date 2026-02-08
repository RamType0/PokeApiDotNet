using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemCategory : INamedApiResource<ItemCategory>
{
    public static string EndpointPath => "item-category";
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
    /// A list of items that are a part of this category.
    /// </summary>
    [JsonPropertyName("items")]
    [Description("A list of items that are a part of this category.")]
    public required ImmutableArray<NamedApiResourceReference<Item>> Items { get; init; }
    /// <summary>
    /// The name of this item category listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this item category listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// The pocket items in this category would be put in.
    /// </summary>
    [JsonPropertyName("pocket")]
    [Description("The pocket items in this category would be put in.")]
    public required NamedApiResourceReference<ItemPocket> Pocket { get; init; }
}
