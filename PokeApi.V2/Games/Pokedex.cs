using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Pokedex : INamedApiResource<Pokedex>
{
    public static string EndpointPath => "pokedex";
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
    /// Whether or not this Pokédex originated in the main series of the video games.
    /// </summary>
    [JsonPropertyName("is_main_series")]
    [Description("Whether or not this Pokédex originated in the main series of the video games.")]
    public required bool IsMainSeries { get; init; }

    /// <summary>
    /// The description of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("descriptions")]
    [Description("The description of this resource listed in different languages.")]
    public required ImmutableArray<Description> Descriptions { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A list of Pokémon catalogued in this Pokédex and their indexes.
    /// </summary>
    [JsonPropertyName("pokemon_entries")]
    [Description("A list of Pokémon catalogued in this Pokédex and their indexes.")]
    public required ImmutableArray<PokemonEntry> PokemonEntries { get; init; }

    /// <summary>
    /// The region this Pokédex catalogues Pokémon for.
    /// </summary>
    /// <remarks>
    /// Can be null for Pokédexes that are not associated with a specific region. For example, the 'national' Pokédex.
    /// </remarks>
    [JsonPropertyName("region")]
    [Description("The region this Pokédex catalogues Pokémon for.")]
    public required NamedApiResourceReference<Region>? Region { get; init; }

    /// <summary>
    /// A list of version groups this Pokédex is relevant to.
    /// </summary>
    [JsonPropertyName("version_groups")]
    [Description("A list of version groups this Pokédex is relevant to.")]
    public required ImmutableArray<NamedApiResourceReference<VersionGroup>> VersionGroups { get; init; }


}
