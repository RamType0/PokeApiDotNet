using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemSprites
{
    /// <summary>
    /// The default depiction of this item.
    /// </summary>
    [JsonPropertyName("default")]
    [Description("The default depiction of this item.")]
    public required Uri? Default { get; init; }
}
