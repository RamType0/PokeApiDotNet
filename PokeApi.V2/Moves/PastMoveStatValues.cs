using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PastMoveStatValues
{
    /// <summary>
    /// The percent value of how likely this move is to be successful.
    /// </summary>
    [JsonPropertyName("accuracy")]
    [Description("The percent value of how likely this move is to be successful.")]
    public required int? Accuracy { get; init; }
    /// <summary>
    /// The percent value of how likely it is this moves effect will take effect.
    /// </summary>
    [JsonPropertyName("effect_chance")]
    [Description("The percent value of how likely it is this moves effect will take effect.")]
    public required int? EffectChance { get; init; }
    /// <summary>
    /// The base power of this move with a value of 0 if it does not have a base power.
    /// </summary>
    [JsonPropertyName("power")]
    [Description("The base power of this move with a value of 0 if it does not have a base power.")]
    public required int? Power { get; init; }
    /// <summary>
    /// Power points. The number of times this move can be used.
    /// </summary>
    [JsonPropertyName("pp")]
    [Description("Power points. The number of times this move can be used.")]
    public required int? PP { get; init; }

    /// <summary>
    /// Power points. The number of times this move can be used.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("Power points. The number of times this move can be used.")]
    public required ImmutableArray<VerboseEffect> EffectEntries { get; init; }
    /// <summary>
    /// The elemental type of this move.
    /// </summary>
    [JsonPropertyName("type")]
    [Description("The elemental type of this move.")]
    public required NamedApiResourceReference<Type>? Type { get; init; }
    /// <summary>
    /// The version group in which these move stat values were in effect.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group in which these move stat values were in effect.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
