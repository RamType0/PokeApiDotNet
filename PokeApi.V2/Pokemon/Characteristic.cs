using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Characteristic : IApiResource<Characteristic>
{
    public static string EndpointPath => "characteristic";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }

    /// <summary>
    /// The remainder of the highest stat/IV divided by 5.
    /// </summary>
    [JsonPropertyName("gene_modulo")]
    [Description("The remainder of the highest stat/IV divided by 5.")]
    public required int GeneModulo { get; init; }

    /// <summary>
    /// The possible values of the highest stat that would result in a Pokémon recieving this characteristic when divided by 5.
    /// </summary>
    [JsonPropertyName("possible_values")]
    [Description("The possible values of the highest stat that would result in a Pokémon recieving this characteristic when divided by 5.")]
    public required ImmutableArray<int> PossibleValues { get; init; }
    /// <summary>
    /// The stat which results in this characteristic.
    /// </summary>
    [JsonPropertyName("highest_stat")]
    [Description("The stat which results in this characteristic.")]
    public required NamedApiResourceReference<Stat> HighestStat { get; init; }

    /// <summary>
    /// The descriptions of this characteristic listed in different languages.
    /// </summary>
    [JsonPropertyName("descriptions")]
    [Description("The descriptions of this characteristic listed in different languages.")]
    public required ImmutableArray<Description> Descriptions { get; init; }
}
