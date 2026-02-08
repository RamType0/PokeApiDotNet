using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ContestType : INamedApiResource<ContestType>
{
    public static string EndpointPath => "contest-type";
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
    /// The berry flavor that correlates with this contest type.
    /// </summary>
    [JsonPropertyName("berry_flavor")]
    [Description("The berry flavor that correlates with this contest type.")]
    public required NamedApiResourceReference<BerryFlavor> BerryFlavor { get; init; }

    /// <summary>
    /// The name of this contest type listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this contest type listed in different languages.")]
    public required ImmutableArray<ContestName> Names { get; init; }
}
