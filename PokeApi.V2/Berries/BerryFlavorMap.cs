using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record BerryFlavorMap
{
    /// <summary>
    /// How powerful the referenced flavor is for this berry.
    /// </summary>
    [JsonPropertyName("potency")]
    [Description("How powerful the referenced flavor is for this berry.")]
    public required int Potency { get; init; }
    /// <summary>
    /// The referenced berry flavor.
    /// </summary>
    [JsonPropertyName("flavor")]
    [Description("The referenced berry flavor.")]
    public required NamedApiResourceReference<BerryFlavor> Flavor { get; init; }
}
