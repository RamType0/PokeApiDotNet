using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonCries
{
    /// <summary>
    /// The latest depiction of this Pokémon's cry.
    /// </summary>
    [JsonPropertyName("latest")]
    [Description("The latest depiction of this Pokémon's cry.")]
    public required Uri? Latest { get; init; }
    /// <summary>
    /// The legacy depiction of this Pokémon's cry.
    /// </summary>
    [JsonPropertyName("legacy")]
    [Description("The legacy depiction of this Pokémon's cry.")]
    public required Uri? Legacy { get; init; }
}
