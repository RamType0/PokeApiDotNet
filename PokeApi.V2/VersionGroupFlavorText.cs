using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record VersionGroupFlavorText
{
    /// <summary>
    /// The localized name for an API resource in a specific language.
    /// </summary>
    [JsonPropertyName("text")]
    [Description("The localized name for an API resource in a specific language.")]
    public required string Text { get; init; }

    /// <summary>
    /// The language this name is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }

    /// <summary>
    /// The version group which uses this flavor text.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group which uses this flavor text.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
