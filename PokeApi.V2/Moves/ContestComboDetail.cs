using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ContestComboDetail
{
    /// <summary>
    /// A list of moves to use before this move.
    /// </summary>
    [JsonPropertyName("use_before")]
    [Description("A list of moves to use before this move.")]
    public required ImmutableArray<NamedApiResourceReference<Move>>? UseBefore { get; init; }
    /// <summary>
    /// A list of moves to use after this move.
    /// </summary>
    [JsonPropertyName("use_after")]
    [Description("A list of moves to use after this move.")]
    public required ImmutableArray<NamedApiResourceReference<Move>>? UseAfter { get; init; }
}
