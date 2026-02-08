using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonType
{
    /// <summary>
    /// The order the Pokémon's types are listed in.
    /// </summary>
    [JsonPropertyName("slot")]
    [Description("The order the Pokémon's types are listed in.")]
    public required int Slot { get; init; }
    /// <summary>
    /// The type the referenced Pokémon has.
    /// </summary>
    [JsonPropertyName("type")]
    [Description("The type the referenced Pokémon has.")]
    public required NamedApiResourceReference<Type> Type { get; init; }
}
