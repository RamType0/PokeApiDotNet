using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record VerboseEffect : Effect
{

    /// <summary>
    /// The localized effect text in brief.
    /// </summary>
    [JsonPropertyName("short_effect")]
    [Description("The localized effect text in brief.")]
    public required string ShortEffect { get; init; }

}
