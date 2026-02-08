using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record TypeRelationsPast
{
    /// <summary>
    /// The last generation in which the referenced type had the listed damage relations
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The last generation in which the referenced type had the listed damage relations")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }
    /// <summary>
    /// The damage relations the referenced type had up to and including the listed generation
    /// </summary>
    [JsonPropertyName("damage_relations")]
    [Description("The damage relations the referenced type had up to and including the listed generation")]
    public required TypeRelations DamageRelations { get; init; }
}
