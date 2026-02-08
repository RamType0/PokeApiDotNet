using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PalParkEncounterArea
{
    /// <summary>
    /// The base score given to the player when the referenced Pokémon is caught during a pal park run.
    /// </summary>
    [JsonPropertyName("base_score")]
    [Description("The base score given to the player when the referenced Pokémon is caught during a pal park run.")]
    public required int BaseScore { get; init; }
    /// <summary>
    /// The base rate for encountering the referenced Pokémon in this pal park area.
    /// </summary>
    [JsonPropertyName("rate")]
    [Description("The base rate for encountering the referenced Pokémon in this pal park area.")]
    public required int Rate { get; init; }
    /// <summary>
    /// The pal park area where this encounter happens.
    /// </summary>
    [JsonPropertyName("area")]
    [Description("The pal park area where this encounter happens.")]
    public required NamedApiResourceReference<PalParkArea> Area { get; init; }
}
