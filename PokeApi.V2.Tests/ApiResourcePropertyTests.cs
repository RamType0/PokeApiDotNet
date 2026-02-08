namespace PokeApi.V2.Tests;

public abstract class ApiResourcePropertyTests<TResource, TProperty>(PokeApiClientFixture fixture)
    where TResource : IApiResource<TResource>
    where TProperty : IApiResourceProperty<TResource, TProperty>
{
    public PokeApiClientFixture Fixture { get; } = fixture;
    [Fact]
    public Task GetApiResourcePropertySucceedsWithId()
    {
        return Fixture.Client.GetApiResourcePropertyAsync<TProperty>(1, TestContext.Current.CancellationToken);
    }
    [Fact]
    [Trait("Category", "Full")]
    public async Task EnumerateAllApiResourcePropertiesSucceeds()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        await Assert.AllAsync(Fixture.Client.EnumerateApiResourcesAsync<TResource>(100, cancellationToken), r => Fixture.Client.GetApiResourcePropertyAsync<TResource, TProperty>(r, cancellationToken));
    }
}
