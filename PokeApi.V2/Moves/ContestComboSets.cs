using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ContestComboSets
{
    /// <summary>
    /// A detail of moves this move can be used before or after, granting additional appeal points in contests.
    /// </summary>
    [JsonPropertyName("normal")]
    [Description("A detail of moves this move can be used before or after, granting additional appeal points in contests.")]
    public required ContestComboDetail Normal { get; init; }
    /// <summary>
    /// A detail of moves this move can be used before or after, granting additional appeal points in super contests.
    /// </summary>
    [JsonPropertyName("super")]
    [Description("A detail of moves this move can be used before or after, granting additional appeal points in super contests.")]
    public required ContestComboDetail Super { get; init; }
}
