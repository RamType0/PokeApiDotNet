using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Effect : EffectBase;
public abstract record EffectBase
{
    /// <summary>
    /// The localized effect text for an API resource in a specific language.
    /// </summary>
    [JsonPropertyName("effect")]
    [Description("The localized effect text for an API resource in a specific language.")]
    public required string Effect { get; init; }

    /// <summary>
    /// The language this effect is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this effect is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
}
