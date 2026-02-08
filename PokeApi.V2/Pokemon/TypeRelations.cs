using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record TypeRelations
{
    /// <summary>
    /// A list of types this type has no effect on.
    /// </summary>
    [JsonPropertyName("no_damage_to")]
    [Description("A list of types this type has no effect on.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> NoDamageTo { get; init; }
    /// <summary>
    /// A list of types this type is not very effect against.
    /// </summary>
    [JsonPropertyName("half_damage_to")]
    [Description("A list of types this type is not very effect against.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> HalfDamageTo { get; init; }
    /// <summary>
    /// A list of types this type is very effect against.
    /// </summary>
    [JsonPropertyName("double_damage_to")]
    [Description("A list of types this type is very effect against.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> DoubleDamageTo { get; init; }
    /// <summary>
    /// A list of types that have no effect on this type.
    /// </summary>
    [JsonPropertyName("no_damage_from")]
    [Description("A list of types that have no effect on this type.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> NoDamageFrom { get; init; }
    /// <summary>
    /// A list of types that are not very effective against this type.
    /// </summary>
    [JsonPropertyName("half_damage_from")]
    [Description("A list of types that are not very effective against this type.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> HalfDamageFrom { get; init; }
    /// <summary>
    /// A list of types that are very effective against this type.
    /// </summary>
    [JsonPropertyName("double_damage_from")]
    [Description("A list of types that are very effective against this type.")]
    public required ImmutableArray<NamedApiResourceReference<Type>> DoubleDamageFrom { get; init; }
}
