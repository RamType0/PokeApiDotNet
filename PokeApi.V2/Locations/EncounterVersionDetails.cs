using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EncounterVersionDetails
{
    /// <summary>
    /// The chance of an encounter to occur.
    /// </summary>
    [JsonPropertyName("rate")]
    [Description("The chance of an encounter to occur.")]
    public required int Rate { get; init; }

    /// <summary>
    /// The version of the game in which the encounter can occur with the given chance.
    /// </summary>
    [JsonPropertyName("version")]
    [Description("The version of the game in which the encounter can occur with the given chance.")]
    public required NamedApiResourceReference<Version> Version { get; init; }
}
