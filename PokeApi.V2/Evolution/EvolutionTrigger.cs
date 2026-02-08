using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EvolutionTrigger : INamedApiResource<EvolutionTrigger>
{
    public static string EndpointPath => "evolution-trigger";
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
    /// A list of pokemon species that result from this evolution trigger.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("A list of pokemon species that result from this evolution trigger.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonSpecies>> PokemonSpecies { get; init; }
}
