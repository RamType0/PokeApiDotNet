using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record GrowthRateExperienceLevel
{
    /// <summary>
    /// The level gained.
    /// </summary>
    [JsonPropertyName("level")]
    [Description("The level gained.")]
    public required int Level { get; init; }

    /// <summary>
    /// The amount of experience required to reach the referenced level.
    /// </summary>
    [JsonPropertyName("experience")]
    [Description("The amount of experience required to reach the referenced level.")]
    public required int Experience { get; init; }
}
