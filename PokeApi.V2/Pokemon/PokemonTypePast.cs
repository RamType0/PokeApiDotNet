using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonTypePast
{
    /// <summary>
    /// The last generation in which the referenced pokémon had the listed types.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The last generation in which the referenced pokémon had the listed types.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }
    /// <summary>
    /// The types the referenced pokémon had up to and including the listed generation.
    /// </summary>
    [JsonPropertyName("types")]
    [Description("The types the referenced pokémon had up to and including the listed generation.")]
    public required ImmutableArray<PokemonType> Types { get; init; }
}
