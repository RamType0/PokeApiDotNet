using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonAbility
{
    /// <summary>
    /// Whether or not this is a hidden ability.
    /// </summary>
    [JsonPropertyName("is_hidden")]
    [Description("Whether or not this is a hidden ability.")]
    public required bool IsHidden { get; init; }
    /// <summary>
    /// The slot this ability occupies in this Pokémon species.
    /// </summary>
    [JsonPropertyName("slot")]
    [Description("The slot this ability occupies in this Pokémon species.")]
    public required int Slot { get; init; }
    /// <summary>
    /// The ability the Pokémon may have.
    /// </summary>
    [JsonPropertyName("ability")]
    [Description("The ability the Pokémon may have.")]
    public required NamedApiResourceReference<Ability>? Ability { get; init; }
}
