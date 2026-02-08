using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

/// <summary>
/// Represents a reference to named resource of type <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// Called <c>NamedAPIResource</c> in the official documentation.
/// </remarks>
public record NamedApiResourceReference<T> : ApiResourceReference<T> where T : INamedApiResource
{
    /// <summary>
    /// The name of the referenced resource.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The name of the referenced resource.")]
    public required string Name { get; init; }
}