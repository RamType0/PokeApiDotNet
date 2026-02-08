using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record FlavorText : FlavorTextBase;
public abstract record FlavorTextBase
{
    /// <summary>
    /// The localized flavor text for an API resource in a specific language.
    /// </summary>
    /// <remarks>
    /// Note that this text is left unprocessed as it is found in game files. This means that it contains special characters that one might want to replace with their visible decodable version. Please check out this issue to find out more.
    /// </remarks>
    [JsonPropertyName("flavor_text")]
    [Description("The localized flavor text for an API resource in a specific language.")]
    public required string FlavorText { get; init; }
    /// <summary>
    /// The language this name is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
    /// <summary>
    /// The game version this flavor text is extracted from.
    /// </summary>
    [JsonPropertyName("version")]
    [Description("The game version this flavor text is extracted from.")]
    public required NamedApiResourceReference<Version> Version { get; init; }
}
