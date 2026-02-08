using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record LocationArea : INamedApiResource<LocationArea>
{
    public static string EndpointPath => "location-area";
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
    /// The internal id of an API resource within game data.
    /// </summary>
    [JsonPropertyName("game_index")]
    [Description("The internal id of an API resource within game data.")]
    public required int GameIndex { get; init; }

    /// <summary>
    /// A list of methods in which Pokémon may be encountered in this area and how likely the method will occur depending on the version of the game.
    /// </summary>
    [JsonPropertyName("encounter_method_rates")]
    [Description("A list of methods in which Pokémon may be encountered in this area and how likely the method will occur depending on the version of the game.")]
    public required ImmutableArray<EncounterMethodRate> EncounterMethodRates { get; init; }

    /// <summary>
    /// The region this location area can be found in.
    /// </summary>
    [JsonPropertyName("location")]
    [Description("The region this location area can be found in.")]
    public required NamedApiResourceReference<Location> Location { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// A list of Pokémon that can be encountered in this area along with version specific details about the encounter.
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    [Description("A list of Pokémon that can be encountered in this area along with version specific details about the encounter.")]
    public required ImmutableArray<PokemonEncounter> PokemonEncounters { get; init; }
}
