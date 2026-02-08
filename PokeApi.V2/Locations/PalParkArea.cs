using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PalParkArea : INamedApiResource<PalParkArea>
{
    public static string EndpointPath => "pal-park-area";
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
    /// A list of Pokémon encountered in this pal park area along with details.
    /// </summary>
    [JsonPropertyName("pokemon_encounters")]
    [Description("A list of Pokémon encountered in this pal park area along with details.")]
    public required ImmutableArray<PalParkEncounterSpecies> PokemonEncounters { get; init; }
}
