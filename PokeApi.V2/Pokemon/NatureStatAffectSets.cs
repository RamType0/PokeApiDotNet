using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record NatureStatAffectSets
{
    /// <summary>
    /// A list of natures and how they change the referenced stat.
    /// </summary>
    [JsonPropertyName("increase")]
    [Description("A list of natures and how they change the referenced stat.")]
    public required ImmutableArray<NamedApiResourceReference<Nature>> Increase { get; init; }
    /// <summary>
    /// A list of natures and how they change the referenced stat.
    /// </summary>
    [JsonPropertyName("decrease")]
    [Description("A list of natures and how they change the referenced stat.")]
    public required ImmutableArray<NamedApiResourceReference<Nature>> Decrease { get; init; }
}
