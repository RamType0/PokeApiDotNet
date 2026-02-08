using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Machine : IApiResource<Machine>
{
    public static string EndpointPath => "machine";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }

    /// <summary>
    /// The TM or HM item that corresponds to this machine.
    /// </summary>
    [JsonPropertyName("item")]
    [Description("The TM or HM item that corresponds to this machine.")]
    public required NamedApiResourceReference<Item> Item { get; init; }
    /// <summary>
    /// The move that is taught by this machine.
    /// </summary>
    [JsonPropertyName("move")]
    [Description("The move that is taught by this machine.")]
    public required NamedApiResourceReference<Move> Move { get; init; }
    /// <summary>
    /// The version group that this machine applies to.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group that this machine applies to.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
