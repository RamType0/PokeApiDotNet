using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Pokemon : INamedApiResource<Pokemon>
{
    public static string EndpointPath => "pokemon";
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
    /// The base experience gained for defeating this Pokémon.
    /// </summary>
    [JsonPropertyName("base_experience")]
    [Description("The base experience gained for defeating this Pokémon.")]
    public required int? BaseExperience { get; init; }

    /// <summary>
    /// The height of this Pokémon in decimetres.
    /// </summary>
    [JsonPropertyName("height")]
    [Description("The height of this Pokémon in decimetres.")]
    public required int Height { get; init; }

    /// <summary>
    /// Set for exactly one Pokémon used as the default for each species.
    /// </summary>
    [JsonPropertyName("is_default")]
    [Description("Set for exactly one Pokémon used as the default for each species.")]
    public required bool IsDefault { get; init; }

    /// <summary>
    /// Order for sorting. Almost national order, except families are grouped together.
    /// </summary>
    [JsonPropertyName("order")]
    [Description("Order for sorting. Almost national order, except families are grouped together.")]
    public required int Order { get; init; }

    /// <summary>
    /// The weight of this Pokémon in hectograms.
    /// </summary>
    [JsonPropertyName("weight")]
    [Description("The weight of this Pokémon in hectograms.")]
    public required int Weight { get; init; }

    /// <summary>
    /// A list of abilities this Pokémon could potentially have.
    /// </summary>
    [JsonPropertyName("abilities")]
    [Description("A list of abilities this Pokémon could potentially have.")]
    public required ImmutableArray<PokemonAbility> Abilities { get; init; }

    /// <summary>
    /// A list of forms this Pokémon can take on.
    /// </summary>
    [JsonPropertyName("forms")]
    [Description("A list of forms this Pokémon can take on.")]
    public required ImmutableArray<NamedApiResourceReference<PokemonForm>> Forms { get; init; }

    /// <summary>
    /// A list of game indices relevent to Pokémon item by generation.
    /// </summary>
    [JsonPropertyName("game_indices")]
    [Description("A list of game indices relevent to Pokémon item by generation.")]
    public required ImmutableArray<VersionGameIndex> GameIndices { get; init; }

    /// <summary>
    /// A list of items this Pokémon may be holding when encountered.
    /// </summary>
    [JsonPropertyName("held_items")]
    [Description("A list of items this Pokémon may be holding when encountered.")]
    public required ImmutableArray<PokemonHeldItem> HeldItems { get; init; }

    /// <summary>
    /// A link to a list of location areas, as well as encounter details pertaining to specific versions.
    /// </summary>
    [JsonPropertyName("location_area_encounters")]
    [Description("A link to a list of location areas, as well as encounter details pertaining to specific versions.")]
    public required Uri LocationAreaEncounters { get; init; }

    /// <summary>
    /// A list of moves along with learn methods and level details pertaining to specific version groups.
    /// </summary>
    [JsonPropertyName("moves")]
    [Description("A list of moves along with learn methods and level details pertaining to specific version groups.")]
    public required ImmutableArray<PokemonMove> Moves { get; init; }

    /// <summary>
    /// A list of details showing types this pokémon had in previous generations
    /// </summary>
    [JsonPropertyName("past_types")]
    [Description("A list of details showing types this pokémon had in previous generations")]
    public required ImmutableArray<PokemonTypePast> PastTypes { get; init; }

    /// <summary>
    /// A list of details showing abilities this pokémon had in previous generations
    /// </summary>
    [JsonPropertyName("past_abilities")]
    [Description("A list of details showing abilities this pokémon had in previous generations")]
    public required ImmutableArray<PokemonAbilityPast> PastAbilities { get; init; }


    /// <summary>
    /// A set of sprites used to depict this Pokémon in the game. A visual representation of the various sprites can be found at <see href="https://github.com/PokeAPI/sprites#sprites">PokeAPI/sprites</see>
    /// </summary>
    [JsonPropertyName("sprites")]
    [Description("A set of sprites used to depict this Pokémon in the game. A visual representation of the various sprites can be found at [PokeAPI/sprites](https://github.com/PokeAPI/sprites#sprites)")]
    public required PokemonSprites Sprites { get; init; }

    /// <summary>
    /// A set of cries used to depict this Pokémon in the game. A visual representation of the various cries can be found at <see href="https://github.com/PokeAPI/cries#cries">PokeAPI/cries</see>
    /// </summary>
    [JsonPropertyName("cries")]
    [Description("A set of cries used to depict this Pokémon in the game. A visual representation of the various cries can be found at [PokeAPI/cries](https://github.com/PokeAPI/cries#cries)")]
    public required PokemonCries Cries { get; init; }
    /// <summary>
    /// The species this Pokémon belongs to.
    /// </summary>
    [JsonPropertyName("species")]
    [Description("The species this Pokémon belongs to.")]
    public required NamedApiResourceReference<PokemonSpecies> Species { get; init; }


    /// <summary>
    /// A list of base stat values for this Pokémon.
    /// </summary>
    [JsonPropertyName("stats")]
    [Description("A list of base stat values for this Pokémon.")]
    public required ImmutableArray<PokemonStat> Stats { get; init; }

    /// <summary>
    /// A list of details showing types this Pokémon has.
    /// </summary>
    [JsonPropertyName("types")]
    [Description("A list of details showing types this Pokémon has.")]
    public required ImmutableArray<PokemonType> Types { get; init; }
}
