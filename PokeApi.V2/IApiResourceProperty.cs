namespace PokeApi.V2;

public interface IApiResourceProperty
{
    public abstract static string RelativePath { get; }
    public abstract static string CreateUrl(int id);
}
public interface IApiResourceProperty<TResource, TSelf> : IApiResourceProperty
    where TResource : notnull, IApiResource
    where TSelf : notnull, IApiResourceProperty<TResource, TSelf>
{
    public virtual static string CreateUrl(ApiResourceReference<TResource> apiResourceReference)
    {
        return $"{apiResourceReference.Url.AbsoluteUri}{TSelf.RelativePath}";
    }
    static string IApiResourceProperty.CreateUrl(int id) => $"{TResource.CreateUrl(id)}{TSelf.RelativePath}";
}