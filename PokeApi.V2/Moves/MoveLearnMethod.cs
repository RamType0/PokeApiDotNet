using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveLearnMethod : INamedApiResource<MoveLearnMethod>
{
    public static string EndpointPath => "move-learn-method";
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
    /// A list of version groups where moves can be learned through this method.
    /// </summary>
    [JsonPropertyName("version_groups")]
    [Description("A list of version groups where moves can be learned through this method.")]
    public required ImmutableArray<NamedApiResourceReference<VersionGroup>> VersionGroups { get; init; }
}
