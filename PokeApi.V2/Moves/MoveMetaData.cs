using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveMetaData
{
    /// <summary>
    /// The status ailment this move inflicts on its target.
    /// </summary>
    [JsonPropertyName("ailment")]
    [Description("The status ailment this move inflicts on its target.")]
    public required NamedApiResourceReference<MoveAilment> Ailment { get; init; }
    /// <summary>
    /// The category of move this move falls under, e.g. damage or ailment.
    /// </summary>
    [JsonPropertyName("category")]
    [Description("The category of move this move falls under, e.g. damage or ailment.")]
    public required NamedApiResourceReference<MoveCategory> Category { get; init; }
    /// <summary>
    /// The minimum number of times this move hits. Null if it always only hits once.
    /// </summary>
    [JsonPropertyName("min_hits")]
    [Description("The minimum number of times this move hits. Null if it always only hits once.")]
    public required int? MinHits { get; init; }
    /// <summary>
    /// The maximum number of times this move hits. Null if it always only hits once.
    /// </summary>
    [JsonPropertyName("max_hits")]
    [Description("The maximum number of times this move hits. Null if it always only hits once.")]
    public required int? MaxHits { get; init; }
    /// <summary>
    /// The minimum number of turns this move continues to take effect. Null if it always only lasts one turn.
    /// </summary>
    [JsonPropertyName("min_turns")]
    [Description("The minimum number of turns this move continues to take effect. Null if it always only lasts one turn.")]
    public required int? MinTurns { get; init; }
    /// <summary>
    /// The maximum number of turns this move continues to take effect. Null if it always only lasts one turn.
    /// </summary>
    [JsonPropertyName("max_turns")]
    [Description("The maximum number of turns this move continues to take effect. Null if it always only lasts one turn.")]
    public required int? MaxTurns { get; init; }
    /// <summary>
    /// HP drain (if positive) or Recoil damage (if negative), in percent of damage done.
    /// </summary>
    [JsonPropertyName("drain")]
    [Description("HP drain (if positive) or Recoil damage (if negative), in percent of damage done.")]
    public required int Drain { get; init; }
    /// <summary>
    /// The amount of hp gained by the attacking Pokemon, in percent of it's maximum HP.
    /// </summary>
    [JsonPropertyName("healing")]
    [Description("The amount of hp gained by the attacking Pokemon, in percent of it's maximum HP.")]
    public required int Healing { get; init; }
    /// <summary>
    /// Critical hit rate bonus.
    /// </summary>
    [JsonPropertyName("crit_rate")]
    [Description("Critical hit rate bonus.")]
    public required int CritRate { get; init; }
    /// <summary>
    /// /The likelihood this attack will cause an ailment.
    /// </summary>
    [JsonPropertyName("ailment_chance")]
    [Description("The likelihood this attack will cause an ailment.")]
    public required int AilmentChance { get; init; }
    /// <summary>
    /// The likelihood this attack will cause the target Pokémon to flinch.
    /// </summary>
    [JsonPropertyName("flinch_chance")]
    [Description("The likelihood this attack will cause the target Pokémon to flinch.")]
    public required int FlinchChance { get; init; }
    /// <summary>
    /// The likelihood this attack will cause a stat change in the target Pokémon.
    /// </summary>
    [JsonPropertyName("stat_chance")]
    [Description("The likelihood this attack will cause a stat change in the target Pokémon.")]
    public required int StatChance { get; init; }
}
