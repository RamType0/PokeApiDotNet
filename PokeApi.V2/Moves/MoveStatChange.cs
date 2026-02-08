using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveStatChange
{
    /// <summary>
    /// The amount of change.
    /// </summary>
    [JsonPropertyName("change")]
    [Description("The amount of change.")]
    public required int Change { get; init; }
    /// <summary>
    /// The stat being affected.
    /// </summary>
    [JsonPropertyName("stat")]
    [Description("The stat being affected.")]
    public required NamedApiResourceReference<Stat> Stat { get; init; }
}
