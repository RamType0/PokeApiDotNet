using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record LocationAreaEncounter
{

    /// <summary>
    /// The location area the referenced Pokémon can be encountered in.
    /// </summary>
    [JsonPropertyName("location_area")]
    [Description("The location area the referenced Pokémon can be encountered in.")]
    public required NamedApiResourceReference<LocationArea> LocationArea { get; init; }

    /// <summary>
    /// A list of versions and encounters with the referenced Pokémon that might happen.
    /// </summary>
    [JsonPropertyName("version_details")]
    [Description("A list of versions and encounters with the referenced Pokémon that might happen.")]
    public required ImmutableArray<VersionEncounterDetail> VersionDetails { get; init; }
}
