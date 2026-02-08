using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Location : INamedApiResource<Location>
{
    public static string EndpointPath => "location";
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
    /// The region this location can be found in.
    /// </summary>
    [JsonPropertyName("region")]
    [Description("The region this location can be found in.")]
    public required NamedApiResourceReference<Region>? Region { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A list of game indices relevent to this location by generation.
    /// </summary>
    [JsonPropertyName("game_indices")]
    [Description("A list of game indices relevent to this location by generation.")]
    public required ImmutableArray<GenerationGameIndex> GameIndices { get; init; }

    /// <summary>
    /// Areas that can be found within this location.
    /// </summary>
    [JsonPropertyName("areas")]
    [Description("Areas that can be found within this location.")]
    public required ImmutableArray<NamedApiResourceReference<LocationArea>> Areas { get; init; }
}
