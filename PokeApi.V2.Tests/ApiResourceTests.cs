namespace PokeApi.V2.Tests;

public abstract class ApiResourceTests<TResource>(PokeApiClientFixture fixture)
    where TResource : IApiResource<TResource>
{
    public PokeApiClientFixture Fixture { get; } = fixture;
    [Fact]
    public Task GetApiResourceSucceedsWithId()
    {
        return Fixture.Client.GetApiResourceAsync<TResource>(1, TestContext.Current.CancellationToken);
    }
    [Fact]
    public Task GetApiResourcePageSucceeds()
    {
        return Fixture.Client.GetApiResourcePageAsync<TResource>(0, 5, TestContext.Current.CancellationToken);
    }
    [Fact]
    [Trait("Category", "Full")]
    public async Task EnumerateAllApiResourcesSucceeds()
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        await Assert.AllAsync(Fixture.Client.EnumerateApiResourcesAsync<TResource>(100, cancellationToken), r => Fixture.Client.GetApiResourceAsync(r, cancellationToken));
    }

    
}
