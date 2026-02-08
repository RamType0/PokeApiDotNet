using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonStat
{
    /// <summary>
    /// The stat the Pokémon has.
    /// </summary>
    [JsonPropertyName("stat")]
    [Description("The stat the Pokémon has.")]
    public required NamedApiResourceReference<Stat> Stat { get; init; }
    /// <summary>
    /// The effort points (EV) the Pokémon has in the stat.
    /// </summary>
    [JsonPropertyName("effort")]
    [Description("The effort points (EV) the Pokémon has in the stat.")]
    public required int Effort { get; init; }
    /// <summary>
    /// The base value of the stat.
    /// </summary>
    [JsonPropertyName("base_stat")]
    [Description("The base value of the stat.")]
    public required int BaseStat { get; init; }
}
