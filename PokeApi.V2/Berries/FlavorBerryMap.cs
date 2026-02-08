using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record FlavorBerryMap
{
    /// <summary>
    /// How powerful the referenced flavor is for this berry.
    /// </summary>
    [JsonPropertyName("potency")]
    [Description("How powerful the referenced flavor is for this berry.")]
    public required int Potency { get; init; }
    /// <summary>
    /// The berry with the referenced flavor.
    /// </summary>
    [JsonPropertyName("berry")]
    [Description("The berry with the referenced flavor.")]
    public required NamedApiResourceReference<Berry> Berry { get; init; }
}
