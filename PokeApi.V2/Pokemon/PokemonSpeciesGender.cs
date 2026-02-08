using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonSpeciesGender
{
    /// <summary>
    /// The chance of this Pokémon being female, in eighths; or -1 for genderless.
    /// </summary>
    [JsonPropertyName("rate")]
    [Description("The chance of this Pokémon being female, in eighths; or -1 for genderless.")]
    public required int Rate { get; init; }

    /// <summary>
    /// A Pokémon species that can be the referenced gender.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("A Pokémon species that can be the referenced gender.")]
    public required NamedApiResourceReference<PokemonSpecies> PokemonSpecies { get; init; }
}
