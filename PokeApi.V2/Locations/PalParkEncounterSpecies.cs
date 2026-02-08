using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PalParkEncounterSpecies
{
    /// <summary>
    /// The base score given to the player when this Pokémon is caught during a pal park run.
    /// </summary>
    [JsonPropertyName("base_score")]
    [Description("The base score given to the player when this Pokémon is caught during a pal park run.")]
    public required int BaseScore { get; init; }
    /// <summary>
    /// The base rate for encountering this Pokémon in this pal park area.
    /// </summary>
    [JsonPropertyName("rate")]
    [Description("The base rate for encountering this Pokémon in this pal park area.")]
    public required int Rate { get; init; }
    /// <summary>
    /// The Pokémon species being encountered.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("The Pokémon species being encountered.")]
    public required NamedApiResourceReference<PokemonSpecies> PokemonSpecies { get; init; }
}
