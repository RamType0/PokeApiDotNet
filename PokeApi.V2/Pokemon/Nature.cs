using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Nature : INamedApiResource<Nature>
{
    public static string EndpointPath => "nature";
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
    /// The stat decreased by 10% in Pokémon with this nature.
    /// </summary>
    [JsonPropertyName("decreased_stat")]
    [Description("The stat decreased by 10% in Pokémon with this nature.")]
    public required NamedApiResourceReference<Stat>? DecreasedStat { get; init; }

    /// <summary>
    /// The stat increased by 10% in Pokémon with this nature.
    /// </summary>
    [JsonPropertyName("increased_stat")]
    [Description("The stat increased by 10% in Pokémon with this nature.")]
    public required NamedApiResourceReference<Stat>? IncreasedStat { get; init; }

    /// <summary>
    /// The flavor hated by Pokémon with this nature.
    /// </summary>
    [JsonPropertyName("hates_flavor")]
    [Description("The flavor hated by Pokémon with this nature.")]
    public required NamedApiResourceReference<BerryFlavor>? HatesFlavor { get; init; }
    /// <summary>
    /// The flavor liked by Pokémon with this nature.
    /// </summary>
    [JsonPropertyName("likes_flavor")]
    [Description("The flavor liked by Pokémon with this nature.")]
    public required NamedApiResourceReference<BerryFlavor>? LikesFlavor { get; init; }


    /// <summary>
    /// A list of Pokéathlon stats this nature effects and how much it effects them.
    /// </summary>
    [JsonPropertyName("pokeathlon_stat_changes")]
    [Description("A list of Pokéathlon stats this nature effects and how much it effects them.")]
    public required ImmutableArray<NatureStatChange> PokeathlonStatChanges { get; init; }

    /// <summary>
    /// A list of battle styles and how likely a Pokémon with this nature is to use them in the Battle Palace or Battle Tent.
    /// </summary>
    [JsonPropertyName("move_battle_style_preferences")]
    [Description("A list of battle styles and how likely a Pokémon with this nature is to use them in the Battle Palace or Battle Tent.")]
    public required ImmutableArray<MoveBattleStylePreference> MoveBattleStylePreferences { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
}
