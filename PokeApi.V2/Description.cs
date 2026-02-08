using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Description : DescriptionBase;
public abstract record DescriptionBase
{
    /// <summary>
    /// The localized description for an API resource in a specific language.
    /// </summary>
    [JsonPropertyName("description")]
    [Description("The localized description for an API resource in a specific language.")]
    public required string Description { get; init; }

    /// <summary>
    /// The language this name is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
}