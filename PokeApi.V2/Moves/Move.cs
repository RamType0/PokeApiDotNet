using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Move : INamedApiResource<Move>
{
    public static string EndpointPath => "move";
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
    /// The percent value of how likely this move is to be successful.
    /// </summary>
    [JsonPropertyName("accuracy")]
    [Description("The percent value of how likely this move is to be successful.")]
    public required int? Accuracy { get; init; }
    /// <summary>
    /// The percent value of how likely it is this moves effect will happen.
    /// </summary>
    [JsonPropertyName("effect_chance")]
    [Description("The percent value of how likely it is this moves effect will happen.")]
    public required int? EffectChance { get; init; }
    /// <summary>
    /// Power points. The number of times this move can be used.
    /// </summary>
    /// <remarks>
    /// Could be null for moves that do not have PP. For example, Shadow moves.
    /// </remarks>
    [JsonPropertyName("pp")]
    [Description("Power points. The number of times this move can be used.")]
    public required int? PP { get; init; }
    /// <summary>
    /// A value between -8 and 8. Sets the order in which moves are executed during battle.
    /// </summary>
    [JsonPropertyName("priority")]
    [Description("A value between -8 and 8. Sets the order in which moves are executed during battle.")]
    public required int Priority { get; init; }
    /// <summary>
    /// The base power of this move with a value of 0 if it does not have a base power.
    /// </summary>
    [JsonPropertyName("power")]
    [Description("The base power of this move with a value of 0 if it does not have a base power.")]
    public required int? Power { get; init; }


    /// <summary>
    /// A detail of normal and super contest combos that require this move.
    /// </summary>
    [JsonPropertyName("contest_combos")]
    [Description("A detail of normal and super contest combos that require this move.")]
    public required ContestComboSets? ContestCombos { get; init; }
    /// <summary>
    /// The type of appeal this move gives a Pokémon when used in a contest.
    /// </summary>
    [JsonPropertyName("contest_type")]
    [Description("The type of appeal this move gives a Pokémon when used in a contest.")]
    public required NamedApiResourceReference<ContestType>? ContestType { get; init; }

    /// <summary>
    /// TThe effect the move has when used in a contest.
    /// </summary>
    [JsonPropertyName("contest_effect")]
    [Description("The effect the move has when used in a contest.")]
    public required ApiResourceReference<ContestEffect>? ContestEffect { get; init; }
    /// <summary>
    /// The type of damage the move inflicts on the target, e.g. physical.
    /// </summary>
    [JsonPropertyName("damage_class")]
    [Description("The type of damage the move inflicts on the target, e.g. physical.")]
    public required NamedApiResourceReference<MoveDamageClass> DamageClass { get; init; }
    /// <summary>
    /// The effect of this move listed in different languages.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("The effect of this move listed in different languages.")]
    public required ImmutableArray<VerboseEffect> EffectEntries { get; init; }

    /// <summary>
    /// The list of previous effects this move has had across version groups of the games.
    /// </summary>
    [JsonPropertyName("effect_changes")]
    [Description("The list of previous effects this move has had across version groups of the games.")]
    public required ImmutableArray<AbilityEffectChange> EffectChanges { get; init; }
    /// <summary>
    /// List of Pokemon that can learn the move
    /// </summary>
    [JsonPropertyName("learned_by_pokemon")]
    [Description("List of Pokemon that can learn the move")]
    public required ImmutableArray<NamedApiResourceReference<Pokemon>> LearnedByPokemon { get; init; }

    /// <summary>
    /// The flavor text of this move listed in different languages.
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [Description("The flavor text of this move listed in different languages.")]
    public required ImmutableArray<MoveFlavorText> FlavorTextEntries { get; init; }
    /// <summary>
    /// The generation in which this move was introduced.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The generation in which this move was introduced.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }

    /// <summary>
    /// A list of the machines that teach this move.
    /// </summary>
    [JsonPropertyName("machines")]
    [Description("A list of the machines that teach this move.")]
    public required ImmutableArray<MachineVersionDetail> Machines { get; init; }

    /// <summary>
    /// Metadata about this move
    /// </summary>
    [JsonPropertyName("meta")]
    [Description("Metadata about this move")]
    public required MoveMetaData? Meta { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
    /// <summary>
    /// A list of move resource value changes across version groups of the game.
    /// </summary>
    [JsonPropertyName("past_values")]
    [Description("A list of move resource value changes across version groups of the game.")]
    public required ImmutableArray<PastMoveStatValues> PastValues { get; init; }
    /// <summary>
    /// A list of stats this moves effects and how much it effects them.
    /// </summary>
    [JsonPropertyName("stat_changes")]
    [Description("A list of stats this moves effects and how much it effects them.")]
    public required ImmutableArray<MoveStatChange> StatChanges { get; init; }
    /// <summary>
    /// The effect the move has when used in a super contest.
    /// </summary>
    [JsonPropertyName("super_contest_effect")]
    [Description("The effect the move has when used in a super contest.")]
    public required ApiResourceReference<SuperContestEffect>? SuperContestEffect { get; init; }
    /// <summary>
    /// The type of target that will receive the effects of the attack.
    /// </summary>
    [JsonPropertyName("target")]
    [Description("The type of target that will receive the effects of the attack.")]
    public required NamedApiResourceReference<MoveTarget> Target { get; init; }
    /// <summary>
    /// The elemental type of this move.
    /// </summary>
    [JsonPropertyName("type")]
    [Description("The elemental type of this move.")]
    public required NamedApiResourceReference<Type> Type { get; init; }

}
