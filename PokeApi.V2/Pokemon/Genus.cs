using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Genus : GenusBase;
public abstract record GenusBase
{
    /// <summary>
    /// The localized genus for the referenced Pokémon species
    /// </summary>
    [JsonPropertyName("genus")]
    [Description("The localized genus for the referenced Pokémon species")]
    public required string Genus { get; init; }
    /// <summary>
    /// The language this genus is in.
    /// </summary>
    [JsonPropertyName("language")]
    [Description("The language this genus is in.")]
    public required NamedApiResourceReference<Language> Language { get; init; }
}
