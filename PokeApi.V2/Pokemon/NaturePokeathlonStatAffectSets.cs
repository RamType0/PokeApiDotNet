using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record NaturePokeathlonStatAffectSets
{
    /// <summary>
    /// A list of natures and how they change the referenced Pokéathlon stat.
    /// </summary>
    [JsonPropertyName("increase")]
    [Description("A list of natures and how they change the referenced Pokéathlon stat.")]
    public required ImmutableArray<NaturePokeathlonStatAffect> Increase { get; init; }
    /// <summary>
    /// A list of natures and how they change the referenced Pokéathlon stat.
    /// </summary>
    [JsonPropertyName("decrease")]
    [Description("A list of natures and how they change the referenced Pokéathlon stat.")]
    public required ImmutableArray<NaturePokeathlonStatAffect> Decrease { get; init; }
}
