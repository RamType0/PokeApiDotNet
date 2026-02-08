using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveStatAffect
{
    /// <summary>
    /// The maximum amount of change to the referenced stat.
    /// </summary>
    [JsonPropertyName("change")]
    [Description("The maximum amount of change to the referenced stat.")]
    public required int Change { get; init; }
    /// <summary>
    /// The move causing the change.
    /// </summary>
    [JsonPropertyName("move")]
    [Description("The move causing the change.")]
    public required NamedApiResourceReference<Move> Move { get; init; }
}
