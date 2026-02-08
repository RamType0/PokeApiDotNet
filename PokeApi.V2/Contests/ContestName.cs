using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ContestName
{
    /// <summary>
    /// The name for this contest.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The name for this contest.")]
    public required string Name { get; init; }
    /// <summary>
    /// The color associated with this contest's name.
    /// </summary>
    [JsonPropertyName("color")]
    [Description("The color associated with this contest's name.")]
    public required string Color { get; init; }
    /// <summary>
    /// The language that this name is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language that this name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
}