using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonSpeciesDexEntry
{
    /// <summary>
    /// The index number within the Pokédex.
    /// </summary>
    [JsonPropertyName("entry_number")]
    [Description("The index number within the Pokédex.")]
    public required int EntryNumber { get; init; }
    /// <summary>
    /// The Pokédex the referenced Pokémon species can be found in.
    /// </summary>
    [JsonPropertyName("pokedex")]
    [Description("The Pokédex the referenced Pokémon species can be found in.")]
    public required NamedApiResourceReference<Pokedex> Pokedex { get; init; }
}
