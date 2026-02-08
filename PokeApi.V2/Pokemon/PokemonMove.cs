using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonMove
{
    /// <summary>
    /// The move the Pokémon can learn.
    /// </summary>
    [JsonPropertyName("move")]
    [Description("The move the Pokémon can learn.")]
    public required NamedApiResourceReference<Move> Move { get; init; }
    /// <summary>
    /// The details of the version in which the Pokémon can learn the move.
    /// </summary>
    [JsonPropertyName("version_group_details")]
    [Description("The details of the version in which the Pokémon can learn the move.")]
    public required ImmutableArray<PokemonMoveVersion> VersionGroupDetails { get; init; }
}
