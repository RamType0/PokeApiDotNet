using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Stat : INamedApiResource<Stat>
{
    public static string EndpointPath => "stat";
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
    /// ID the games use for this stat.
    /// </summary>
    [JsonPropertyName("game_index")]
    [Description("ID the games use for this stat.")]
    public required int GameIndex { get; init; }

    /// <summary>
    /// Whether this stat only exists within a battle.
    /// </summary>
    [JsonPropertyName("is_battle_only")]
    [Description("Whether this stat only exists within a battle.")]
    public required bool IsBattleOnly { get; init; }


    /// <summary>
    /// A detail of moves which affect this stat positively or negatively.
    /// </summary>
    [JsonPropertyName("affecting_moves")]
    [Description("A detail of moves which affect this stat positively or negatively.")]
    public required MoveStatAffectSets AffectingMoves { get; init; }

    /// <summary>
    /// A detail of natures which affect this stat positively or negatively.
    /// </summary>
    [JsonPropertyName("affecting_natures")]
    [Description("A detail of natures which affect this stat positively or negatively.")]
    public required NatureStatAffectSets AffectingNatures { get; init; }
    /// <summary>
    /// A list of characteristics that are set on a Pokémon when its highest base stat is this stat.
    /// </summary>
    [JsonPropertyName("characteristics")]
    [Description("A list of characteristics that are set on a Pokémon when its highest base stat is this stat.")]
    public required ImmutableArray<ApiResourceReference<Characteristic>> Characteristics { get; init; }


    /// <summary>
    /// The class of damage this stat is directly related to.
    /// </summary>
    [JsonPropertyName("move_damage_class")]
    [Description("The class of damage this stat is directly related to.")]
    public required NamedApiResourceReference<MoveDamageClass>? MoveDamageClass { get; init; }
    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }
}
