using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;
/// <summary>
/// Represents a reference to resource. Called <c>APIResource</c> in the official documentation.
/// </summary>
/// <remarks>
/// Called <c>APIResource</c> in the official documentation.
/// </remarks>
public abstract record ApiResourceReference
{
    /// <summary>
    /// The URL of the referenced resource.
    /// </summary>
    [JsonPropertyName("url")]
    [Description("The URL of the referenced resource.")]
    public required Uri Url { get; init; }
}
/// <summary>
/// Represents a reference to resource of type <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// Called <c>APIResource</c> in the official documentation.
/// </remarks>
public record ApiResourceReference<T> : ApiResourceReference where T : IApiResource;
