using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record GrowthRate : INamedApiResource<GrowthRate>
{
    public static string EndpointPath => "growth-rate";
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
    /// The formula used to calculate the rate at which the Pokémon species gains level.
    /// </summary>
    [JsonPropertyName("formula")]
    [Description("The formula used to calculate the rate at which the Pokémon species gains level.")]
    public required string Formula { get; init; }

    /// <summary>
    /// The descriptions of this characteristic listed in different languages.
    /// </summary>
    [JsonPropertyName("descriptions")]
    [Description("The descriptions of this characteristic listed in different languages.")]
    public required ImmutableArray<Description> Descriptions { get; init; }

    /// <summary>
    /// A list of levels and the amount of experienced needed to atain them based on this growth rate.
    /// </summary>
    [JsonPropertyName("levels")]
    [Description("A list of levels and the amount of experienced needed to atain them based on this growth rate.")]
    public required ImmutableArray<GrowthRateExperienceLevel> Levels { get; init; }

    /// <summary>
    /// A list of Pokémon species that gain levels at this growth rate.
    /// </summary>
    [JsonPropertyName("pokemon_species")]
    [Description("A list of Pokémon species that gain levels at this growth rate.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonSpecies>> PokemonSpecies { get; init; }
}
