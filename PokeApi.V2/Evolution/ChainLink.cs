using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ChainLink
{
    /// <summary>
    /// Whether or not this link is for a baby Pokémon. This would only ever be true on the base link.
    /// </summary>
    [JsonPropertyName("is_baby")]
    [Description("Whether or not this link is for a baby Pokémon. This would only ever be true on the base link.")]
    public required bool IsBaby { get; init; }

    /// <summary>
    /// The Pokémon species at this point in the evolution chain.
    /// </summary>
    [JsonPropertyName("species")]
    [Description("The Pokémon species at this point in the evolution chain.")]
    public required NamedApiResourceReference<PokemonSpecies> Species { get; init; }

    /// <summary>
    /// All details regarding the specific details of the referenced Pokémon species evolution.
    /// </summary>
    [JsonPropertyName("evolution_details")]
    [Description("All details regarding the specific details of the referenced Pokémon species evolution.")]
    public required ImmutableArray<EvolutionDetail> EvolutionDetails { get; init; }

    /// <summary>
    /// A List of chain objects.
    /// </summary>
    [JsonPropertyName("evolves_to")]
    [Description("A List of chain objects.")]
    public required ImmutableArray<ChainLink> EvolvesTo { get; init; }
}
