using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemHolderPokemonVersionDetail
{

    /// <summary>
    /// How often this Pokémon holds this item in this version.
    /// </summary>
    [JsonPropertyName("rarity")]
    [Description("How often this Pokémon holds this item in this version.")]
    public required int Rarity { get; init; }
    /// <summary>
    /// The version that this item is held in by the Pokémon.
    /// </summary>
    [JsonPropertyName("version")]
    [Description("The version that this item is held in by the Pokémon.")]
    public required NamedApiResourceReference<Version> Version { get; init; }
}
