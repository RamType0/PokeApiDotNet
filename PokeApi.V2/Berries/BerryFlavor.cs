using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record BerryFlavor : INamedApiResource<BerryFlavor>
{
    public static string EndpointPath => "berry-flavor";
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
    /// A list of the berries with this flavor.
    /// </summary>
    [JsonPropertyName("berries")]
    [Description("A list of the berries with this flavor.")]
    public required ImmutableArray<FlavorBerryMap> Berries { get; init; }

    /// <summary>
    /// The contest type that correlates with this berry flavor.
    /// </summary>
    [JsonPropertyName("contest_type")]
    [Description("The contest type that correlates with this berry flavor.")]
    public required NamedApiResourceReference<ContestType> ContestType { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
}
