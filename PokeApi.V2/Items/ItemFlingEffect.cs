using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemFlingEffect : INamedApiResource<ItemFlingEffect>
{
    public static string EndpointPath => "item-fling-effect";
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
    /// The result of this fling effect listed in different languages.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("The result of this fling effect listed in different languages.")]
    public required ImmutableArray<Effect> EffectEntries { get; init; }
    /// <summary>
    /// A list of items that have this fling effect.
    /// </summary>
    [JsonPropertyName("items")]
    [Description("A list of items that have this fling effect.")]
    public required ImmutableArray<NamedApiResourceReference<Item>> Items { get; init; }
}
