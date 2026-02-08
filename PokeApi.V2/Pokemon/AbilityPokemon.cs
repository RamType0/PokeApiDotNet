using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record AbilityPokemon
{
    /// <summary>
    /// Whether or not this a hidden ability for the referenced Pokémon.
    /// </summary>
    [JsonPropertyName("is_hidden")]
    [Description("Whether or not this a hidden ability for the referenced Pokémon.")]
    public required bool IsHidden { get; init; }
    /// <summary>
    /// Pokémon have 3 ability 'slots' which hold references to possible abilities they could have. This is the slot of this ability for the referenced Pokémon.
    /// </summary>
    [JsonPropertyName("slot")]
    [Description("Pokémon have 3 ability 'slots' which hold references to possible abilities they could have. This is the slot of this ability for the referenced Pokémon.")]
    public required int Slot { get; init; }
    /// <summary>
    /// The Pokémon this ability could belong to.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("The Pokémon this ability could belong to.")]
    public required NamedApiResourceReference<Pokemon> Pokemon { get; init; }
}
