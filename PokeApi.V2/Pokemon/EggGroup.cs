using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EggGroup : INamedApiResource<EggGroup>
{
    public static string EndpointPath => "egg-group";
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
    ///The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// A list of all Pokémon species that are members of this egg group.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("A list of all Pokémon species that are members of this egg group.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonSpecies>> PokemonSpecies { get; init; }
}
