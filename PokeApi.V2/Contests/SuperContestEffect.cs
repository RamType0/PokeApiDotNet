using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record SuperContestEffect : IApiResource<SuperContestEffect>
{
    public static string EndpointPath => "super-contest-effect";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }

    /// <summary>
    /// The level of appeal this super contest effect has.
    /// </summary>
    [JsonPropertyName("appeal")]
    [Description("The level of appeal this super contest effect has.")]
    public required int Appeal { get; init; }

    /// <summary>
    /// The flavor text of this super contest effect listed in different languages.
    /// </summary>
    [JsonPropertyName("flavor_text_entries")]
    [Description("The flavor text of this super contest effect listed in different languages.")]
    public required ImmutableArray<FlavorText> FlavorTextEntries { get; init; }

    /// <summary>
    /// A list of moves that have the effect when used in super contests.
    /// </summary>
    [JsonPropertyName("moves")]
    [Description("A list of moves that have the effect when used in super contests.")]
    public required ImmutableArray<NamedApiResourceReference<Move>> Moves { get; init; }
}
