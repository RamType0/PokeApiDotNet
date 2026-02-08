using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonHeldItemVersion
{
    /// <summary>
    /// The version in which the item is held.
    /// </summary>
    [JsonPropertyName("version")]
    [Description("The version in which the item is held.")]
    public required NamedApiResourceReference<Version> Version { get; init; }
    /// <summary>
    /// How often the item is held.
    /// </summary>
    [JsonPropertyName("rarity")]
    [Description("How often the item is held.")]
    public required int Rarity { get; init; }

}
