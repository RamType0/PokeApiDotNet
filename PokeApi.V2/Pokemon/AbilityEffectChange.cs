using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record AbilityEffectChange
{
    /// <summary>
    /// The previous effect of this ability listed in different languages.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("The previous effect of this ability listed in different languages.")]
    public required ImmutableArray<Effect> EffectEntries { get; init; }
    /// <summary>
    /// The version group in which the previous effect of this ability originated.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group in which the previous effect of this ability originated.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }
}
