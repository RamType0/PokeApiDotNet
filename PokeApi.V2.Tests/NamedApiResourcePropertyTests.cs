namespace PokeApi.V2.Tests;

public abstract class NamedApiResourcePropertyTests<TResource, TProperty>(PokeApiClientFixture fixture, string resourceName) : ApiResourcePropertyTests<TResource, TProperty>(fixture)
    where TResource : INamedApiResource<TResource>
    where TProperty : INamedApiResourceProperty<TResource, TProperty>
{
    [Fact]
    public Task GetApiResourcePropertySucceedsWithName()
    {
        return Fixture.Client.GetApiResourcePropertyAsync<TProperty>(resourceName, TestContext.Current.CancellationToken);
    }
}