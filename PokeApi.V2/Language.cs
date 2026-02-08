using System.Collections.Immutable;
using System.ComponentModel;
using System.Globalization;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Language : INamedApiResource<Language>
{
    public static string EndpointPath => "language";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }
    /// <summary>
    /// The name for this resource.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The name for this resource.")]
    public required string Name { get; init; }
    /// <summary>	
    /// Whether or not the games are published in this language.
    /// </summary>
    [JsonPropertyName("official")]
    [Description("Whether or not the games are published in this language.")]
    public required bool Official { get; init; }
    /// <summary>
    /// The two-letter code of the country where this language is spoken. Note that it is not unique.
    /// </summary>
    [JsonPropertyName("iso639")]
    [Description("The two-letter code of the country where this language is spoken. Note that it is not unique.")]
    public required string Iso639 { get; init; }
    /// <summary>
    /// The two-letter code of the language. Note that it is not unique.
    /// </summary>
    [JsonPropertyName("iso3166")]
    [Description("The two-letter code of the language. Note that it is not unique.")]
    public required string Iso3166 { get; init; }
    public CultureInfo ToCultureInfo() => new($"{Iso639}-{Iso3166}");
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
}
