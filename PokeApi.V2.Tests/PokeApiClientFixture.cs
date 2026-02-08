[assembly: AssemblyFixture(typeof(PokeApi.V2.Tests.PokeApiClientFixture))]

namespace PokeApi.V2.Tests;


public class PokeApiClientFixture : IDisposable
{
    public PokeApiClient Client { get; } = new PokeApiClient();

    public void Dispose() => Client.Dispose();
}