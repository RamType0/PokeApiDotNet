using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonHeldItem
{

    /// <summary>
    /// The item the referenced Pokémon holds.
    /// </summary>
    [JsonPropertyName("item")]
    [Description("The item the referenced Pokémon holds.")]
    public required NamedApiResourceReference<Item> Item { get; init; }
    /// <summary>
    /// The details of the different versions in which the item is held.
    /// </summary>
    [JsonPropertyName("version_details")]
    [Description("The details of the different versions in which the item is held.")]
    public required ImmutableArray<PokemonHeldItemVersion> VersionDetails { get; init; }
}
