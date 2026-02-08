using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonEntry
{
    /// <summary>
    /// The index of this Pokémon species entry within the Pokédex.
    /// </summary>
    [JsonPropertyName("entry_number")]
    [Description("The index of this Pokémon species entry within the Pokédex.")]
    public required int EntryNumber { get; init; }

    /// <summary>
    /// The Pokémon species being encountered.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("The Pokémon species being encountered.")]
    public required NamedApiResourceReference<PokemonSpecies> PokemonSpecies { get; init; }
}
