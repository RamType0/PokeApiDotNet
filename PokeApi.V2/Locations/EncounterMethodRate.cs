using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EncounterMethodRate
{
    /// <summary>
    /// The method in which Pokémon may be encountered in an area.
    /// </summary>
    [JsonPropertyName("encounter_method")]
    [Description("The method in which Pokémon may be encountered in an area.")]
    public required NamedApiResourceReference<EncounterMethod> EncounterMethod { get; init; }

    /// <summary>
    /// The chance of the encounter to occur on a version of the game.
    /// </summary>
    [JsonPropertyName("version_details")]
    [Description("The chance of the encounter to occur on a version of the game.")]
    public required ImmutableArray<EncounterVersionDetails> VersionDetails { get; init; }
}
