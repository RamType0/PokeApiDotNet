namespace PokeApi.V2.Tests;

public abstract class NamedApiResourceTests<TResource>(PokeApiClientFixture fixture, string resourceName) : ApiResourceTests<TResource>(fixture)
    where TResource : INamedApiResource<TResource>
{
    [Fact]
    public Task GetApiResourceSucceedsWithName()
    {
        return Fixture.Client.GetApiResourceAsync<TResource>(resourceName, TestContext.Current.CancellationToken);
    }
}
