using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonForm : INamedApiResource<PokemonForm>
{
    public static string EndpointPath => "pokemon-form";
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
    /// The order in which forms should be sorted within all forms. Multiple forms may have equal order, in which case they should fall back on sorting by name.
    /// </summary>
    [JsonPropertyName("order")]
    [Description("The order in which forms should be sorted within all forms. Multiple forms may have equal order, in which case they should fall back on sorting by name.")]
    public required int Order { get; init; }

    /// <summary>
    /// The order in which forms should be sorted within a species' forms.
    /// </summary>
    [JsonPropertyName("form_order")]
    [Description("The order in which forms should be sorted within a species' forms.")]
    public required int FormOrder { get; init; }

    /// <summary>
    /// True for exactly one form used as the default for each Pokémon.
    /// </summary>
    [JsonPropertyName("is_default")]
    [Description("True for exactly one form used as the default for each Pokémon.")]
    public required bool IsDefault { get; init; }

    /// <summary>
    /// Whether or not this form can only happen during battle.
    /// </summary>
    [JsonPropertyName("is_battle_only")]
    [Description("Whether or not this form can only happen during battle.")]
    public required bool IsBattleOnly { get; init; }

    /// <summary>
    /// Whether or not this form requires mega evolution.
    /// </summary>
    [JsonPropertyName("is_mega")]
    [Description("Whether or not this form requires mega evolution.")]
    public required bool IsMega { get; init; }

    /// <summary>
    /// The name of this form.
    /// </summary>
    [JsonPropertyName("form_name")]
    [Description("The name of this form.")]
    public required string FormName { get; init; }

    /// <summary>
    /// The Pokémon that can take on this form.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("The Pokémon that can take on this form.")]
    public required NamedApiResourceReference<Pokemon> Pokemon { get; init; }

    /// <summary>
    /// A list of details showing types this Pokémon form has.
    /// </summary>
    [JsonPropertyName("types")]
    [Description("A list of details showing types this Pokémon form has.")]
    public required ImmutableArray<PokemonFormType> Types { get; init; }
    /// <summary>
    /// A set of sprites used to depict this Pokémon form in the game.
    /// </summary>
    [JsonPropertyName("sprites")]
    [Description("A set of sprites used to depict this Pokémon form in the game.")]
    public required PokemonFormSprites Sprites { get; init; }

    /// <summary>
    /// The version group this Pokémon form was introduced in.
    /// </summary>
    [JsonPropertyName("version_group")]
    [Description("The version group this Pokémon form was introduced in.")]
    public required NamedApiResourceReference<VersionGroup> VersionGroup { get; init; }

    /// <summary>
    /// The form specific full name of this Pokémon form, or empty if the form does not have a specific name.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The form specific full name of this Pokémon form, or empty if the form does not have a specific name.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// The form specific form name of this Pokémon form, or empty if the form does not have a specific name.
    /// </summary>
    [JsonPropertyName("form_names")]
    [Description("The form specific form name of this Pokémon form, or empty if the form does not have a specific name.")]
    public required ImmutableArray<Name> FormNames { get; init; }

}
