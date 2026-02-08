using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record VersionEncounterDetail
{
    /// <summary>
    /// The game version this encounter happens in.
    /// </summary>
    [JsonPropertyName("version")]
    [Description("The game version this encounter happens in.")]
    public required NamedApiResourceReference<Version> Version { get; init; }
    /// <summary>
    /// The total percentage of all encounter potential.
    /// </summary>
    [JsonPropertyName("max_chance")]
    [Description("The total percentage of all encounter potential.")]
    public required int MaxChance { get; init; }
    /// <summary>
    /// A list of encounters and their specifics.
    /// </summary>
    [JsonPropertyName("encounter_details")]
    [Description("A list of encounters and their specifics.")]
    public required ImmutableArray<Encounter> EncounterDetails { get; init; }
}
