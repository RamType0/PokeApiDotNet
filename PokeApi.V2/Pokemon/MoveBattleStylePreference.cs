using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveBattleStylePreference
{
    /// <summary>
    /// Chance of using the move, in percent, if HP is under one half.
    /// </summary>
    [JsonPropertyName("low_hp_preference")]
    [Description("Chance of using the move, in percent, if HP is under one half.")]
    public required int LowHpPreference { get; init; }
    /// <summary>
    /// Chance of using the move, in percent, if HP is over one half.
    /// </summary>
    [JsonPropertyName("high_hp_preference")]
    [Description("Chance of using the move, in percent, if HP is over one half.")]
    public required int HighHpPreference { get; init; }
    /// <summary>
    /// The move battle style.
    /// </summary>
    [JsonPropertyName("move_battle_style")]
    [Description("The move battle style.")]
    public required NamedApiResourceReference<MoveBattleStyle> MoveBattleStyle { get; init; }
}
