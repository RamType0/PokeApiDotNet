using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Generation : INamedApiResource<Generation>
{
    public static string EndpointPath => "generation";
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
    /// A list of abilities that were introduced in this generation.
    /// </summary>
    [JsonPropertyName("abilities")]
    [Description("A list of abilities that were introduced in this generation.")]
    public required ImmutableArray<NamedApiResourceReference<Ability>> Abilities { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// The main region travelled in this generation.
    /// </summary>
    [JsonPropertyName("main_region")]
    [Description("The main region travelled in this generation.")]
    public required NamedApiResourceReference<Region> MainRegion { get; init; }

    /// <summary>
    /// A list of moves that were introduced in this generation.
    /// </summary>
    [JsonPropertyName("moves")]
    [Description("A list of moves that were introduced in this generation.")]
    public required ImmutableArray<NamedApiResourceReference<Move>> Moves { get; init; }

    /// <summary>
    /// A list of Pokémon species that were introduced in this generation.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("A list of Pokémon species that were introduced in this generation.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonSpecies>> PokemonSpecies { get; init; }

    /// <summary>
    /// A list of types that were introduced in this generation.
    /// </summary>
    [JsonPropertyName("types")]
    [Description("A list of types that were introduced in this generation.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> Types { get; init; }

    /// <summary>
    /// A list of version groups that were introduced in this generation.
    /// </summary>
    [JsonPropertyName("version_groups")]
    [Description("A list of version groups that were introduced in this generation.")]
    public required ImmutableArray<NamedApiResourceReference<VersionGroup>> VersionGroups { get; init; }
}
