using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record MoveCategory : INamedApiResource<MoveCategory>
{
    public static string EndpointPath => "move-category";
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
    /// A list of moves that fall into this category.
    /// </summary>
    [JsonPropertyName("moves")]
    [Description("A list of moves that fall into this category.")]
    public required ImmutableArray<NamedApiResourceReference<Move>> Moves { get; init; }
    /// <summary>
    /// The description of this resource listed in different languages.
    /// </summary>
    [JsonPropertyName("descriptions")]
    [Description("The description of this resource listed in different languages.")]
    public required ImmutableArray<Description> Descriptions { get; init; }

}
