using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record TypePokemon
{
    /// <summary>
    /// The order the Pokémon's types are listed in.
    /// </summary>
    [JsonPropertyName("slot")]
    [Description("The order the Pokémon's types are listed in.")]
    public required int Slot { get; init; }
    /// <summary>
    /// The Pokémon that has the referenced type.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("The Pokémon that has the referenced type.")]
    public required NamedApiResourceReference<Pokemon> Pokemon { get; init; }
}
