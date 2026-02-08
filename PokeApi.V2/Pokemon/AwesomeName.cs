using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;
public record AwesomeName : AwesomeNameBase;
public abstract record AwesomeNameBase
{
    /// <summary>
    /// The localized "scientific" name for an API resource in a specific language.
    /// </summary>
    [JsonPropertyName("awesome_name")]
    [Description("The localized \"scientific\" name for an API resource in a specific language.")]
    public required string AwesomeName { get; init; }

    /// <summary>
    /// The language this "scientific" name is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this \"scientific\" name is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
}