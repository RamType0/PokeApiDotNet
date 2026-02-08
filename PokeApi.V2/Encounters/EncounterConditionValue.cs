using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EncounterConditionValue : INamedApiResource<EncounterConditionValue>
{
    public static string EndpointPath => "encounter-condition-value";
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
    /// The condition this encounter condition value pertains to.
    /// </summary>
    [JsonPropertyName("condition")]
    [Description("The condition this encounter condition value pertains to.")]
    public required NamedApiResourceReference<EncounterCondition> Condition { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
}
