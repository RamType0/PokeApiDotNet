using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Region : INamedApiResource<Region>
{
    public static string EndpointPath => "region";
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
    /// A list of locations that can be found in this region.
    /// </summary>
    [JsonPropertyName("locations")]
    [Description("A list of locations that can be found in this region.")]
    public required ImmutableArray<NamedApiResourceReference<Location>> Locations { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// The generation this region was introduced in.
    /// </summary>
    /// <remarks>
    /// Can be null for regions that were introduced in spin-off games and do not have an associated generation. For example, 'Hisui' region from Pokémon Legends: Arceus.
    /// </remarks>
    [JsonPropertyName("main_generation")]
    [Description("The generation this region was introduced in.")]
    public required NamedApiResourceReference<Generation>? MainGeneration { get; init; }

    /// <summary>
    /// A list of pokédexes that catalogue Pokémon in this region.
    /// </summary>
    [JsonPropertyName("pokedexes")]
    [Description("A list of pokédexes that catalogue Pokémon in this region.")]
    public required ImmutableArray<NamedApiResourceReference<Pokedex>> Pokedexes { get; init; }

    /// <summary>
    /// A list of version groups where this region can be visited.
    /// </summary>
    [JsonPropertyName("version_groups")]
    [Description("A list of version groups where this region can be visited.")]
    public required ImmutableArray<NamedApiResourceReference<VersionGroup>> VersionGroups { get; init; }
}
