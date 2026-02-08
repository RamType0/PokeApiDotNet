using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record VersionGameIndex
{
    /// <summary>
    /// The internal id of an API resource within game data.
    /// </summary>
    [JsonPropertyName("game_index")]
    [Description("The internal id of an API resource within game data.")]
    public required int GameIndex { get; init; }
    /// <summary>
    /// The version relevent to this game index.
    /// </summary>
    [JsonPropertyName("version")]
    [Description("The version relevent to this game index.")]
    public required NamedApiResourceReference<Version> Version { get; init; }
}
