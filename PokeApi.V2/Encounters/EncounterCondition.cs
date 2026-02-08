using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EncounterCondition : INamedApiResource<EncounterCondition>
{
    public static string EndpointPath => "encounter-condition";
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
    /// A list of possible values for this encounter condition.
    /// </summary>
    [JsonPropertyName("values")]
    [Description("A list of possible values for this encounter condition.")]
    public required ImmutableArray<NamedApiResourceReference<EncounterConditionValue>> Values { get; init; }
}
