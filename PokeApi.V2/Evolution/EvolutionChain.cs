using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record EvolutionChain : IApiResource<EvolutionChain>
{
    public static string EndpointPath => "evolution-chain";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }

    /// <summary>
    /// The item that a Pokémon would be holding when mating that would trigger the egg hatching a baby Pokémon rather than a basic Pokémon.
    /// </summary>
    [JsonPropertyName("baby_trigger_item")]
    [Description("The item that a Pokémon would be holding when mating that would trigger the egg hatching a baby Pokémon rather than a basic Pokémon.")]
    public required NamedApiResourceReference<Item>? BabyTriggerItem { get; init; }

    /// <summary>
    /// The base chain link object. Each link contains evolution details for a Pokémon in the chain. Each link references the next Pokémon in the natural evolution order.
    /// </summary>
    [JsonPropertyName("chain")]
    [Description("The base chain link object. Each link contains evolution details for a Pokémon in the chain. Each link references the next Pokémon in the natural evolution order.")]
    public required ChainLink Chain { get; init; }
}
