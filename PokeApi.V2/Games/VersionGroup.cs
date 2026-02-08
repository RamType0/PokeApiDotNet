using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record VersionGroup : INamedApiResource<VersionGroup>
{
    public static string EndpointPath => "version-group";
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
    /// Order for sorting. Almost by date of release, except similar versions are grouped together.
    /// </summary>
    [JsonPropertyName("order")]
    [Description("Order for sorting. Almost by date of release, except similar versions are grouped together.")]
    public required int Order { get; init; }

    /// <summary>
    /// The generation this version was introduced in.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The generation this version was introduced in.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }

    /// <summary>
    /// A list of methods in which Pokémon can learn moves in this version group.
    /// </summary>
    [JsonPropertyName("move_learn_methods")]
    [Description("A list of methods in which Pokémon can learn moves in this version group.")]
    public required ImmutableArray<NamedApiResourceReference<MoveLearnMethod>> MoveLearnMethods { get; init; }

    /// <summary>
    /// A list of Pokédexes introduces in this version group.
    /// </summary>
    [JsonPropertyName("pokedexes")]
    [Description("A list of Pokédexes introduces in this version group.")]
    public required ImmutableArray<NamedApiResourceReference<Pokedex>> Pokedexes { get; init; }

    /// <summary>
    /// A list of regions that can be visited in this version group.
    /// </summary>
    [JsonPropertyName("regions")]
    [Description("A list of regions that can be visited in this version group.")]
    public required ImmutableArray<NamedApiResourceReference<Region>> Regions { get; init; }

    /// <summary>
    /// The versions this version group owns.
    /// </summary>
    [JsonPropertyName("versions")]
    [Description("The versions this version group owns.")]
    public required ImmutableArray<NamedApiResourceReference<Version>> Versions { get; init; }
}
