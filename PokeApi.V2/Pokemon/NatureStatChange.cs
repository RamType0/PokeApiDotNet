using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record NatureStatChange
{
    /// <summary>
    /// The amount of change.
    /// </summary>
    [JsonPropertyName("max_change")]
    [Description("The amount of change.")]
    public required int MaxChange { get; init; }
    /// <summary>
    /// The stat being affected.
    /// </summary>
    [JsonPropertyName("pokeathlon_stat")]
    [Description("The stat being affected.")]
    public required NamedApiResourceReference<PokeathlonStat> PokeathlonStat { get; init; }
}
