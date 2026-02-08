using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveFlavorText
{
    [JsonPropertyName("flavor_text")]
    [Description("The localized flavor text for an API resource in a specific language.")]
    public required string FlavorText { get; init; }

    [JsonPropertyName("language")]
    [Description("The language this name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }

    [JsonPropertyName("version_group")]
    [Description("The version group which uses this flavor text.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
