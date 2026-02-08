using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MachineVersionDetail
{
    /// <summary>
    /// The machine that teaches a move from an item.
    /// </summary>
    [JsonPropertyName("machine")]
    [Description("The machine that teaches a move from an item.")]
    public required ApiResourceReference<Machine> Machine { get; init; }
    /// <summary>
    /// The version group of this specific machine.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group of this specific machine.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
