using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record ItemHolderPokemon
{
    /// <summary>
    /// The Pokémon that holds this item.
    /// </summary>
    [JsonPropertyName("pokemon")]
    [Description("The Pokémon that holds this item.")]
    public required NamedApiResourceReference<Pokemon> Pokemon { get; init; }

    /// <summary>
    /// The details for the version that this item is held in by the Pokémon.
    /// </summary>
    [JsonPropertyName("version_details")]
    [Description("The details for the version that this item is held in by the Pokémon.")]
    public required ImmutableArray<ItemHolderPokemonVersionDetail> VersionDetails { get; init; }
}
