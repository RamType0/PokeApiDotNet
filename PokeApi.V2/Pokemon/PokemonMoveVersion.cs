using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonMoveVersion
{
    /// <summary>
    /// The method by which the move is learned.
    /// </summary>
    [JsonPropertyName("move_learn_method")]
    [Description("The method by which the move is learned.")]
    public required NamedApiResourceReference<MoveLearnMethod> MoveLearnMethod { get; init; }
    /// <summary>
    /// The version group in which the move is learned.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group in which the move is learned.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
    /// <summary>
    /// The minimum level to learn the move.
    /// </summary>
    [JsonPropertyName("level_learned_at")]
    [Description("The minimum level to learn the move.")]
    public required int LevelLearnedAt { get; init; }
    /// <summary>
    /// Order by which the Pokémon will learn the move. A newly learnt move will replace the move with lowest order.
    /// </summary>
    [JsonPropertyName("order")]
    [Description("Order by which the Pokémon will learn the move. A newly learnt move will replace the move with lowest order.")]
    public required int? Order { get; init; }
}
