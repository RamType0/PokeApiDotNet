using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Ability : INamedApiResource<Ability>
{
    public static string EndpointPath => "ability";
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
    /// Whether or not this ability originated in the main series of the video games.
    /// </summary>
    [JsonPropertyName("is_main_series")]
    [Description("Whether or not this ability originated in the main series of the video games.")]
    public required bool IsMainSeries { get; init; }

    /// <summary>
    /// The generation this ability originated in.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The generation this ability originated in.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// The effect of this ability listed in different languages.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("The effect of this ability listed in different languages.")]
    public required ImmutableArray<VerboseEffect> EffectEntries { get; init; }

    /// <summary>
    /// The list of previous effects this ability has had across version groups.
    /// </summary>
    [JsonPropertyName("effect_changes")]
    [Description("The list of previous effects this ability has had across version groups.")]
    public required ImmutableArray<AbilityEffectChange> EffectChanges { get; init; }

    /// <summary>
    /// The flavor text of this ability listed in different languages.
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [Description("The flavor text of this ability listed in different languages.")]
    public required ImmutableArray<AbilityFlavorText> FlavorTextEntries { get; init; }

    /// <summary>
    /// A list of Pokémon that could potentially have this ability.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("A list of Pokémon that could potentially have this ability.")]
    public required ImmutableArray<AbilityPokemon> Pokemon { get; init; }
}
