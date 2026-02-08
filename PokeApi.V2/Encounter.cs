using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Encounter
{
    /// <summary>
    /// The lowest level the Pokémon could be encountered at.
    /// </summary>
    [JsonPropertyName("min_level")]
    [Description("The lowest level the Pokémon could be encountered at.")]
    public required int MinLevel { get; init; }
    /// <summary>
    /// The highest level the Pokémon could be encountered at.
    /// </summary>
    [JsonPropertyName("max_level")]
    [Description("The highest level the Pokémon could be encountered at.")]
    public required int MaxLevel { get; init; }
    /// <summary>
    /// A list of condition values that must be in effect for this encounter to occur.
    /// </summary>
    [JsonPropertyName("condition_values")]
    [Description("A list of condition values that must be in effect for this encounter to occur.")]
    public required ImmutableArray<NamedApiResourceReference<EncounterConditionValue>> ConditionValues { get; init; }
    /// <summary>
    /// Percent chance that this encounter will occur.
    /// </summary>
    [JsonPropertyName("chance")]
    [Description("Percent chance that this encounter will occur.")]
    public required int Chance { get; init; }
    /// <summary>
    /// The method by which this encounter happens.
    /// </summary>
    [JsonPropertyName("method")]
    [Description("The method by which this encounter happens.")]
    public required NamedApiResourceReference<EncounterMethod> Method { get; init; }
}
