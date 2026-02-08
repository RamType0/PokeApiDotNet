using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EvolutionDetail
{
    /// <summary>
    /// The item required to cause evolution this into Pokémon species.
    /// </summary>
    [JsonPropertyName("item")]
    [Description("The item required to cause evolution this into Pokémon species.")]
    public required NamedApiResourceReference<Item>? Item { get; init; }
    /// <summary>
    /// The type of event that triggers evolution into this Pokémon species.
    /// </summary>
    [JsonPropertyName("trigger")]
    [Description("The type of event that triggers evolution into this Pokémon species.")]
    public required NamedApiResourceReference<EvolutionTrigger> Trigger { get; init; }
    /// <summary>
    /// The id of the gender of the evolving Pokémon species must be in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("gender")]
    [Description("The id of the gender of the evolving Pokémon species must be in order to evolve into this Pokémon species.")]
    public required int? Gender { get; init; }
    /// <summary>
    /// The item the evolving Pokémon species must be holding during the evolution trigger event to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("held_item")]
    [Description("The item the evolving Pokémon species must be holding during the evolution trigger event to evolve into this Pokémon species.")]
    public required NamedApiResourceReference<Item>? HeldItem { get; init; }
    /// <summary>
    /// The move that must be known by the evolving Pokémon species during the evolution trigger event in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("known_move")]
    [Description("The move that must be known by the evolving Pokémon species during the evolution trigger event in order to evolve into this Pokémon species.")]
    public required NamedApiResourceReference<Move>? KnownMove { get; init; }
    /// <summary>
    /// The evolving Pokémon species must know a move with this type during the evolution trigger event in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("known_move_type")]
    [Description("The evolving Pokémon species must know a move with this type during the evolution trigger event in order to evolve into this Pokémon species.")]
    public required NamedApiResourceReference<Type>? KnownMoveType { get; init; }
    /// <summary>
    /// The location the evolution must be triggered at.
    /// </summary>
    [JsonPropertyName("location")]
    [Description("The location the evolution must be triggered at.")]
    public required NamedApiResourceReference<Location>? Location { get; init; }
    /// <summary>
    /// The minimum required level of the evolving Pokémon species to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_level")]
    [Description("The minimum required level of the evolving Pokémon species to evolve into this Pokémon species.")]
    public required int? MinLevel { get; init; }
    /// <summary>
    /// The minimum required level of happiness the evolving Pokémon species to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_happiness")]
    [Description("The minimum required level of happiness the evolving Pokémon species to evolve into this Pokémon species.")]
    public required int? MinHappiness { get; init; }
    /// <summary>
    /// The minimum required level of beauty the evolving Pokémon species to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_beauty")]
    [Description("The minimum required level of beauty the evolving Pokémon species to evolve into this Pokémon species.")]
    public required int? MinBeauty { get; init; }
    /// <summary>
    /// The minimum required level of affection the evolving Pokémon species to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_affection")]
    [Description("The minimum required level of affection the evolving Pokémon species to evolve into this Pokémon species.")]
    public required int? MinAffection { get; init; }
    /// <summary>
    /// Whether or not multiplayer link play is needed to evolve into this Pokémon species (e.g. Union Circle).
    /// </summary>
    [JsonPropertyName("needs_multiplayer")]
    [Description("Whether or not multiplayer link play is needed to evolve into this Pokémon species (e.g. Union Circle).")]
    public required bool NeedsMultiplayer { get; init; }
    /// <summary>
    /// Whether or not it must be raining in the overworld to cause evolution this Pokémon species.
    /// </summary>
    [JsonPropertyName("needs_overworld_rain")]
    [Description("Whether or not it must be raining in the overworld to cause evolution this Pokémon species.")]
    public required bool NeedsOverworldRain { get; init; }
    /// <summary>
    /// The Pokémon species that must be in the players party in order for the evolving Pokémon species to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("party_species")]
    [Description("The Pokémon species that must be in the players party in order for the evolving Pokémon species to evolve into this Pokémon species.")]
    public required NamedApiResourceReference<PokemonSpecies>? PartySpecies { get; init; }
    /// <summary>
    /// The player must have a Pokémon of this type in their party during the evolution trigger event in order for the evolving Pokémon species to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("party_type")]
    [Description("The player must have a Pokémon of this type in their party during the evolution trigger event in order for the evolving Pokémon species to evolve into this Pokémon species.")]
    public required NamedApiResourceReference<Type>? PartyType { get; init; }
    /// <summary>
    /// The required relation between the Pokémon's Attack and Defense stats. 1 means Attack &gt; Defense. 0 means Attack = Defense. -1 means Attack &lt; Defense.
    /// </summary>
    [JsonPropertyName("relative_physical_stats")]
    [Description("The required relation between the Pokémon's Attack and Defense stats. 1 means Attack > Defense. 0 means Attack = Defense. -1 means Attack < Defense.")]
    public required int? RelativePhysicalStats { get; init; }
    /// <summary>
    /// The required time of day. Day or night.
    /// </summary>
    [JsonPropertyName("time_of_day")]
    [Description("The required time of day. Day or night.")]
    public required string TimeOfDay { get; init; }
    /// <summary>
    /// Pokémon species for which this one must be traded.
    /// </summary>
    [JsonPropertyName("trade_species")]
    [Description("Pokémon species for which this one must be traded.")]
    public required NamedApiResourceReference<PokemonSpecies>? TradeSpecies { get; init; }
    /// <summary>
    /// Whether or not the 3DS needs to be turned upside-down as this Pokémon levels up.
    /// </summary>
    [JsonPropertyName("turn_upside_down")]
    [Description("Whether or not the 3DS needs to be turned upside-down as this Pokémon levels up.")]
    public required bool TurnUpsideDown { get; init; }
    /// <summary>
    /// The required region in which this evolution can occur.
    /// </summary>
    [JsonPropertyName("region_id")]
    [Description("The required region in which this evolution can occur.")]
    public required NamedApiResourceReference<Region>? Region { get; init; }
    /// <summary>
    /// The required form for which this evolution can occur.
    /// </summary>
    [JsonPropertyName("base_form_id")]
    [Description("The required form for which this evolution can occur.")]
    public required NamedApiResourceReference<PokemonSpecies>? BaseForm { get; init; }
    /// <summary>
    /// The move that must be used by the evolving Pokémon species during the evolution trigger event in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("used_move")]
    [Description("The move that must be used by the evolving Pokémon species during the evolution trigger event in order to evolve into this Pokémon species.")]
    public required NamedApiResourceReference<Move>? UsedMove { get; init; }
    /// <summary>
    /// The minimum number of times a move must be used in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_move_count")]
    [Description("The minimum number of times a move must be used in order to evolve into this Pokémon species.")]
    public required int? MinMoveCount { get; init; }
    /// <summary>
    /// The minimum number of steps that must be taken in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_steps")]
    [Description("The minimum number of steps that must be taken in order to evolve into this Pokémon species.")]
    public required int? MinSteps { get; init; }
    /// <summary>
    /// The minimum amount of damage taken during the evolution trigger event in order to evolve into this Pokémon species.
    /// </summary>
    [JsonPropertyName("min_damage_taken")]
    [Description("The minimum amount of damage taken during the evolution trigger event in order to evolve into this Pokémon species.")]
    public required int? MinDamageTaken { get; init; }
}
