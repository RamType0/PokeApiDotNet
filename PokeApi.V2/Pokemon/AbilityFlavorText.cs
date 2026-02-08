using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record AbilityFlavorText
{
    /// <summary>
    /// The localized name for an API resource in a specific language.
    /// </summary>
    [JsonPropertyName("flavor_text")]
    [Description("The localized name for an API resource in a specific language.")]
    public required string FlavorText { get; init; }
    /// <summary>
    /// The language this text resource is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this text resource is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
    /// <summary>
    /// The version group that uses this flavor text.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group that uses this flavor text.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
