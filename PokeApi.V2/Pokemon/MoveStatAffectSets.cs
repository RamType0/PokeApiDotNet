using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveStatAffectSets
{
    /// <summary>
    /// A list of moves and how they change the referenced stat.
    /// </summary>
    [JsonPropertyName("increase")]
    [Description("A list of moves and how they change the referenced stat.")]
    public required ImmutableArray<MoveStatAffect> Increase { get; init; }
    /// <summary>
    /// A list of moves and how they change the referenced stat.
    /// </summary>
    [JsonPropertyName("decrease")]
    [Description("A list of moves and how they change the referenced stat.")]
    public required ImmutableArray<MoveStatAffect> Decrease { get; init; }
}
