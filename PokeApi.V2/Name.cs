using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Name : NameBase;
public abstract record NameBase
{
    /// <summary>
    /// The localized name for an API resource in a specific language.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The localized name for an API resource in a specific language.")]
    public required string Name { get; init; }
    /// <summary>
    /// The language this name is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
}