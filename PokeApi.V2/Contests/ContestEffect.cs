using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ContestEffect : IApiResource<ContestEffect>
{
    public static string EndpointPath => "contest-effect";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }


    /// <summary>
    /// The base number of hearts the user of this move gets.
    /// </summary>
    [JsonPropertyName("appeal")]
    [Description("The base number of hearts the user of this move gets.")]
    public required int Appeal { get; init; }

    /// <summary>
    /// The base number of hearts the user's opponent loses.
    /// </summary>
    [JsonPropertyName("jam")]
    [Description("The base number of hearts the user's opponent loses.")]
    public required int Jam { get; init; }
    /// <summary>
    /// The result of this contest effect listed in different languages.
    /// </summary>
    [JsonPropertyName("effect_entries")]
    [Description("The result of this contest effect listed in different languages.")]
    public required ImmutableArray<Effect> EffectEntries { get; init; }

    /// <summary>
    /// The flavor text of this contest effect listed in different languages.
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [Description("The flavor text of this contest effect listed in different languages.")]
    public required ImmutableArray<ContestEffectFlavorText> FlavorTextEntries { get; init; }
}
