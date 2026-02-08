using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemAttribute : INamedApiResource<ItemAttribute>
{
    public static string EndpointPath => "item-attribute";
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
    /// A list of items that have this attribute.
    /// </summary>
    [JsonPropertyName("items")]
    [Description("A list of items that have this attribute.")]
    public required ImmutableArray<NamedApiResourceReference<Item>> Items { get; init; }
    /// <summary>
    /// The name of this item attribute listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this item attribute listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// The description of this item attribute listed in different languages.
    /// </summary>
    [JsonPropertyName("descriptions")]
    [Description("The description of this item attribute listed in different languages.")]
    public required ImmutableArray<Description> Descriptions { get; init; }
}
