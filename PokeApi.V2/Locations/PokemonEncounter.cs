using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonEncounter
{
    /// <summary>
    /// The Pokémon being encountered.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("The Pokémon being encountered.")]
    public required NamedApiResourceReference<Pokemon> Pokemon { get; init; }

    /// <summary>
    /// A list of versions and encounters with Pokémon that might happen in the referenced location area.
    /// </summary>
    [JsonPropertyName("version_details")]
    [Description("A list of versions and encounters with Pokémon that might happen in the referenced location area.")]
    public required ImmutableArray<VersionEncounterDetail> VersionDetails { get; init; }
}
