using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Type : INamedApiResource<Type>
{
    public static string EndpointPath => "type";
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
    /// A detail of how effective this type is toward others and vice versa.
    /// </summary>
    [JsonPropertyName("damage_relations")]
    [Description("A detail of how effective this type is toward others and vice versa.")]
    public required TypeRelations DamageRelations { get; init; }

    /// <summary>
    /// A list of details of how effective this type was toward others and vice versa in previous generations
    /// </summary>
    [JsonPropertyName("past_damage_relations")]
    [Description("A list of details of how effective this type was toward others and vice versa in previous generations")]
    public required ImmutableArray<TypeRelationsPast> PastDamageRelations { get; init; }

    /// <summary>
    /// A list of game indices relevent to this item by generation.
    /// </summary>
    [JsonPropertyName("game_indices")]
    [Description("A list of game indices relevent to this item by generation.")]
    public required ImmutableArray<GenerationGameIndex> GameIndices { get; init; }

    /// <summary>
    /// The generation this type was introduced in.
    /// </summary>
    [JsonPropertyName("generation")]
    [Description("The generation this type was introduced in.")]
    public required NamedApiResourceReference<Generation> Generation { get; init; }

    /// <summary>
    /// The class of damage inflicted by this type.
    /// </summary>
    /// <remarks>
    /// This only applies to generations until generation 3.<br/>
    /// Can be null for types introduced in later generations.
    /// </remarks>
    [JsonPropertyName("move_damage_class")]
    [Description("The class of damage inflicted by this type.")]
    public required NamedApiResourceReference<MoveDamageClass>? MoveDamageClass { get; init; }

    /// <summary>
    /// The name of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("names")]
    [Description("The name of this resource listed in different languages.")]
    public required ImmutableArray<Name> Names { get; init; }

    /// <summary>
    /// A list of details of Pokémon that have this type.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("A list of details of Pokémon that have this type.")]
    public required ImmutableArray<TypePokemon> Pokemon { get; init; }

    /// <summary>
    /// A list of moves that have this type.
    /// </summary>
    [JsonPropertyName("moves")]
    [Description("A list of moves that have this type.")]
    public required ImmutableArray<NamedApiResourceReference<Move>> Moves { get; init; }
}
