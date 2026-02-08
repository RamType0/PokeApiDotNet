using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Gender : INamedApiResource<Gender>
{
    public static string EndpointPath => "gender";
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
    /// A list of Pokémon species that can be this gender and how likely it is that they will be.
    /// </summary>
    [JsonPropertyName("pokemon_species_details")]
    [Description("A list of Pokémon species that can be this gender and how likely it is that they will be.")]
    public required ImmutableArray<PokemonSpeciesGender> PokemonSpeciesDetails { get; init; }

    /// <summary>
    /// A list of Pokémon species that required this gender in order for a Pokémon to evolve into them.
    /// </summary>
    [JsonPropertyName("required_for_evolution")]
    [Description("A list of Pokémon species that required this gender in order for a Pokémon to evolve into them.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonSpecies>> RequiredForEvolution { get; init; }
}
