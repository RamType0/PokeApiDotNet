using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonSpeciesVariety
{
    /// <summary>
    /// Whether this variety is the default variety.
    /// </summary>
    [JsonPropertyName("is_default")]
    [Description("Whether this variety is the default variety.")]
    public required bool IsDefault { get; init; }
    /// <summary>
    /// The Pokémon variety.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("The Pokémon variety.")]
    public required NamedApiResourceReference<Pokemon> Pokemon { get; init; }
}
