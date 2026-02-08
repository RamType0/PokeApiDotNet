using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonSpecies : INamedApiResource<PokemonSpecies>
{
    public static string EndpointPath => "pokemon-species";
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
    /// The order in which species should be sorted. Based on National Dex order, except families are grouped together and sorted by stage.
    /// </summary>
    [JsonPropertyName("order")]
    [Description("The order in which species should be sorted. Based on National Dex order, except families are grouped together and sorted by stage.")]
    public required int Order { get; init; }
    /// <summary>
    /// The chance of this Pokémon being female, in eighths; or -1 for genderless.
    /// </summary>
    [JsonPropertyName("gender_rate")]
    [Description("The chance of this Pokémon being female, in eighths; or -1 for genderless.")]
    public required int GenderRate { get; init; }
    /// <summary>
    /// The base capture rate; up to 255. The higher the number, the easier the catch.
    /// </summary>
    [JsonPropertyName("capture_rate")]
    [Description("The base capture rate; up to 255. The higher the number, the easier the catch.")]
    public required int CaptureRate { get; init; }
    /// <summary>
    /// The happiness when caught by a normal Pokéball; up to 255. The higher the number, the happier the Pokémon.
    /// </summary>
    [JsonPropertyName("base_happiness")]
    [Description("The happiness when caught by a normal Pokéball; up to 255. The higher the number, the happier the Pokémon.")]
    public required int BaseHappiness { get; init; }
    /// <summary>
    /// Whether or not this is a baby Pokémon.
    /// </summary>
    [JsonPropertyName("is_baby")]
    [Description("Whether or not this is a baby Pokémon.")]
    public required bool IsBaby { get; init; }
    /// <summary>
    /// Whether or not this is a legendary Pokémon.
    /// </summary>
    [JsonPropertyName("is_legendary")]
    [Description("Whether or not this is a legendary Pokémon.")]
    public required bool IsLegendary { get; init; }

    /// <summary>
    /// Whether or not this is a mythical Pokémon.
    /// </summary>
    [JsonPropertyName("is_mythical")]
    [Description("Whether or not this is a mythical Pokémon.")]
    public required bool IsMythical { get; init; }
    /// <summary>
    /// Number of cycles in an egg before hatch.
    /// </summary>
    [JsonPropertyName("hatch_counter")]
    [Description("Number of cycles in an egg before hatch.")]
    public required int HatchCounter { get; init; }
    /// <summary>
    /// Whether or not this Pokémon has visual gender differences.
    /// </summary>
    [JsonPropertyName("has_gender_differences")]
    [Description("Whether or not this Pokémon has visual gender differences.")]
    public required bool HasGenderDifferences { get; init; }
    /// <summary>
    /// Whether or not this Pokémon has multiple forms and can switch between them.
    /// </summary>
    [JsonPropertyName("forms_switchable")]
    [Description("Whether or not this Pokémon has multiple forms and can switch between them.")]
    public required bool FormsSwitchable { get; init; }
    /// <summary>
    /// The rate at which this Pokémon species gains levels.
    /// </summary>
    [JsonPropertyName("growth_rate")]
    [Description("The rate at which this Pokémon species gains levels.")]
    public required NamedApiResourceReference<GrowthRate> GrowthRate { get; init; }
    /// <summary>
    /// A list of Pokedexes and the indexes reserved within them for this Pokémon species.
    /// </summary>
    [JsonPropertyName("pokedex_numbers")]
    [Description("A list of Pokedexes and the indexes reserved within them for this Pokémon species.")]
    public required ImmutableArray<PokemonSpeciesDexEntry> PokedexNumbers { get; init; }
    /// <summary>
    /// A list of egg groups this Pokémon species is a member of.
    /// </summary>
    [JsonPropertyName("egg_groups")]
    [Description("A list of egg groups this Pokémon species is a member of.")]
    public required ImmutableArray<NamedApiResourceReference<EggGroup>> EggGroups { get; init; }
    /// <summary>
    /// The color of this Pokémon for Pokédex search.
    /// </summary>
    [JsonPropertyName("color")]
    [Description("The color of this Pokémon for Pokédex search.")]
    public required NamedApiResourceReference<PokemonColor> Color { get; init; }
    /// <summary>
    /// The shape of this Pokémon for Pokédex search.
    /// </summary>
    [JsonPropertyName("shape")]
    [Description("The shape of this Pokémon for Pokédex search.")]
    public required NamedApiResourceReference<PokemonShape> Shape { get; init; }
    /// <summary>
    /// The Pokémon species that evolves into this Pokemon_species.
    /// </summary>
    [JsonPropertyName("evolves_from_species")]
    [Description("The Pokémon species that evolves into this Pokemon_species.")]
    public required NamedApiResourceReference<PokemonSpecies>? EvolvesFromSpecies { get; init; }
    /// <summary>
    /// The evolution chain this Pokémon species is a member of.
    /// </summary>
    [JsonPropertyName("evolution_chain")]
    [Description("The evolution chain this Pokémon species is a member of.")]
    public required ApiResourceReference<EvolutionChain> EvolutionChain { get; init; }
    /// <summary>
    /// The habitat this Pokémon species can be encountered in.
    /// </summary>
    [JsonPropertyName("habitat")]
    [Description("The habitat this Pokémon species can be encountered in.")]
    public required NamedApiResourceReference<PokemonHabitat>? Habitat { get; init; }
    /// <summary>
    /// The generation this Pokémon species was introduced in.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The generation this Pokémon species was introduced in.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A list of encounters that can be had with this Pokémon species in pal park.
    /// </summary>
    [JsonPropertyName("pal_park_encounters")]
    [Description("A list of encounters that can be had with this Pokémon species in pal park.")]
    public required ImmutableArray<PalParkEncounterArea> PalParkEncounters { get; init; }
    /// <summary>
    /// A list of flavor text entries for this Pokémon species.
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [Description("A list of flavor text entries for this Pokémon species.")]
    public required ImmutableArray<FlavorText> FlavorTextEntries { get; init; }


    /// <summary>
    /// Descriptions of different forms Pokémon take on within the Pokémon species.
    /// </summary>
    [JsonPropertyName("form_descriptions")]
    [Description("Descriptions of different forms Pokémon take on within the Pokémon species.")]
    public required ImmutableArray<Description> FormDescriptions { get; init; }

    /// <summary>
    /// The genus of this Pokémon species listed in multiple languages.
    /// </summary>
    [JsonPropertyName("genera")]
    [Description("The genus of this Pokémon species listed in multiple languages.")]
    public required ImmutableArray<Genus> Genera { get; init; }
    /// <summary>
    /// A list of the Pokémon that exist within this Pokémon species.
    /// </summary>
    [JsonPropertyName("varieties")]
    [Description("A list of the Pokémon that exist within this Pokémon species.")]
    public required ImmutableArray<PokemonSpeciesVariety> Varieties { get; init; }
}
