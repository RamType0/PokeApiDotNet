namespace PokeApi.V2;

public interface INamedApiResourceProperty : IApiResourceProperty
{
    public abstract static string CreateUrl(ReadOnlySpan<char> name);
}
public interface INamedApiResourceProperty<TResource, TSelf> : INamedApiResourceProperty, IApiResourceProperty<TResource, TSelf>
    where TResource : notnull, IApiResource
    where TSelf : notnull, IApiResourceProperty<TResource, TSelf>
{
    static string INamedApiResourceProperty.CreateUrl(ReadOnlySpan<char> name)
    {
        Span<char> buffer = stackalloc char[name.Length];
        var length = name.ToLowerInvariant(buffer);
        var lowerCaseName = buffer[..length];
        return $"{PokeApiClient.ApiEndpoint}{TResource.EndpointPath}/{lowerCaseName}/{TSelf.RelativePath}";
    }
}