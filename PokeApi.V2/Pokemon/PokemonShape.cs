using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonShape : INamedApiResource<PokemonShape>
{
    public static string EndpointPath => "pokemon-shape";
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
    /// The "scientific" name of this Pokémon shape listed in different languages.
    /// </summary>
    [JsonPropertyName("awesome_names")]
    [Description("The \"scientific\" name of this Pokémon shape listed in different languages.")]
    public required ImmutableArray<AwesomeName> AwesomeNames { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A list of the Pokémon species that have this shape.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("A list of the Pokémon species that have this shape.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonSpecies>> PokemonSpecies { get; init; }
}
