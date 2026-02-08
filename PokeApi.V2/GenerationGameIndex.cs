using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record GenerationGameIndex
{
    /// <summary>
    /// The internal id of an API resource within game data.
    /// </summary>
    [JsonPropertyName("game_index")]
    [Description("The internal id of an API resource within game data.")]
    public required int GameIndex { get; init; }
    /// <summary>
    /// The generation relevent to this game index.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The generation relevent to this game index.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }
}
