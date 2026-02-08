using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record NaturePokeathlonStatAffect
{
    /// <summary>
    /// The maximum amount of change to the referenced Pokeathlon stat.
    /// </summary>
    [JsonPropertyName("max_change")]
    [Description("The maximum amount of change to the referenced Pokeathlon stat.")]
    public required int MaxChange { get; init; }
    /// <summary>
    /// The nature causing the change.
    /// </summary>
    [JsonPropertyName("nature")]
    [Description("The nature causing the change.")]
    public required NamedApiResourceReference<Nature> Nature { get; init; }
}
