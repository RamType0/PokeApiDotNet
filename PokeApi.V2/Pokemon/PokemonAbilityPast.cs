using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonAbilityPast
{
    /// <summary>
    /// The last generation in which the referenced pokémon had the listed abilities.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The last generation in which the referenced pokémon had the listed abilities.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }
    /// <summary>
    /// The abilities the referenced pokémon had up to and including the listed generation. If null, the slot was previously empty.
    /// </summary>
    [JsonPropertyName("abilities")]
    [Description("The abilities the referenced pokémon had up to and including the listed generation. If null, the slot was previously empty.")]
    public required ImmutableArray<PokemonAbility> Abilities { get; init; }
}
