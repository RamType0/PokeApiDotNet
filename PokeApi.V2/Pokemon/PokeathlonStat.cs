using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokeathlonStat : INamedApiResource<PokeathlonStat>
{
    public static string EndpointPath => "pokeathlon-stat";
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
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A detail of natures which affect this Pokéathlon stat positively or negatively.
    /// </summary>
    [JsonPropertyName("affecting_natures")]
    [Description("A detail of natures which affect this Pokéathlon stat positively or negatively.")]
    public required NaturePokeathlonStatAffectSets AffectingNatures { get; init; }


}
