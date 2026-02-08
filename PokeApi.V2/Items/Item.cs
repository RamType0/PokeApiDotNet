using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Item : INamedApiResource<Item>
{
    public static string EndpointPath => "item";
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
    /// The price of this item in stores.
    /// </summary>
    [JsonPropertyName("cost")]
    [Description("The price of this item in stores.")]
    public required int Cost { get; init; }
    /// <summary>
    /// The power of the move Fling when used with this item.
    /// </summary>
    [JsonPropertyName("fling_power")]
    [Description("The power of the move Fling when used with this item.")]
    public required int? FlingPower { get; init; }
    /// <summary>
    /// The effect of the move Fling when used with this item.
    /// </summary>
    [JsonPropertyName("fling_effect")]
    [Description("The effect of the move Fling when used with this item.")]
    public required NamedApiResourceReference<ItemFlingEffect>? FlingEffect { get; init; }
    /// <summary>
    /// A list of attributes this item has.
    /// </summary>
    [JsonPropertyName("attributes")]
    [Description("A list of attributes this item has.")]
    public required ImmutableArray<NamedApiResourceReference<ItemAttribute>> Attributes { get; init; }
    /// <summary>
    /// The category of items this item falls into.
    /// </summary>
    [JsonPropertyName("category")]
    [Description("The category of items this item falls into.")]
    public required NamedApiResourceReference<ItemCategory> Category { get; init; }
    /// <summary>
    /// The effect of this item listed in different languages.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("The effect of this item listed in different languages.")]
    public required ImmutableArray<VerboseEffect> EffectEntries { get; init; }
    /// <summary>
    /// The flavor text of this item listed in different languages.
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [Description("The flavor text of this item listed in different languages.")]
    public required ImmutableArray<VersionGroupFlavorText> FlavorTextEntries { get; init; }
    /// <summary>
    /// A list of game indices relevent to this item by generation.
    /// </summary>
    [JsonPropertyName("game_indices")]
    [Description("A list of game indices relevent to this item by generation.")]
    public required ImmutableArray<GenerationGameIndex> GameIndices { get; init; }
    /// <summary>
    /// The name of this item listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this item listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A set of sprites used to depict this item in the game.
    /// </summary>
    [JsonPropertyName("sprites")]
    [Description("A set of sprites used to depict this item in the game.")]
    public required ItemSprites Sprites { get; init; }
    /// <summary>
    /// A list of Pokémon that might be found in the wild holding this item.
    /// </summary>
    [JsonPropertyName("held_by_pokemon")]
    [Description("A list of Pokémon that might be found in the wild holding this item.")]
    public required ImmutableArray<ItemHolderPokemon> HeldByPokemon { get; init; }
    /// <summary>
    /// An evolution chain this item requires to produce a bay during mating.
    /// </summary>
    [JsonPropertyName("baby_trigger_for")]
    [Description("An evolution chain this item requires to produce a bay during mating.")]
    public required ApiResourceReference<EvolutionChain>? BabyTriggerFor { get; init; }

    /// <summary>
    /// A list of the machines related to this item.
    /// </summary>
    [JsonPropertyName("machines")]
    [Description("A list of the machines related to this item.")]
    public required ImmutableArray<MachineVersionDetail> Machines { get; init; }
}

