# PokeApi.V2

PokeApi.V2 is a .NET client library for accessing [PokéAPI API v2](https://pokeapi.co/docs/v2).

Supports in-memory caching and distributed caching (e.g. Redis).

## Installation

```bash
dotnet add package PokeApi.V2
```

## How to use

### Get Pokémon resource by ID or name
```csharp
using PokeApi.V2;

PokeApiClient client = new();

var pokemonById = await client.GetApiResourceAsync<Pokemon>(1); // Get Pokémon with ID 1 (Bulbasaur)
var pokemonByName = await client.GetApiResourceAsync<Pokemon>("bulbasaur"); // Get Pokémon with name "bulbasaur"

```
### Get Pokemon Location Areas by ID, name, or resource reference
```csharp
using PokeApi.V2;
PokeApiClient client = new();

var locationAreaById = await client.GetApiResourcePropertyAsync<LocationAreaEncounter>(1); // Get Pokemon Location Area of Pokémon with ID 1 (Bulbasaur)
var locationAreaByName = await client.GetApiResourcePropertyAsync<LocationAreaEncounter>("bulbasaur"); // Get Pokemon Location Area of Pokémon with name "bulbasaur"

var pokemonList = await client.GetApiResourceListAsync<Pokemon>(offset: 0, limit: 1);
var pokemonRef = pokemonList.Results.First();
var locationAreaByRef = await client.GetApiResourcePropertyAsync<Pokemon, LocationAreaEncounter>(pokemonRef); // Get Pokemon Location Area using resource reference
```
### Get a list of Pokémon resources with pagination
```csharp
using PokeApi.V2;

PokeApiClient client = new();

var pokemonList = await client.GetApiResourceListAsync<Pokemon>(offset: 0, limit: 20); // Get first 20 Pokémon

foreach (var pokemonRef in pokemonList.Results)
{
    var pokemon = await client.GetApiResourceAsync<Pokemon>(pokemonRef); // Fetch each Pokémon resource using its reference
}
```
### Enumerate all Pokémon resources
```csharp
using PokeApi.V2;
PokeApiClient client = new();
await foreach (var pokemonRef in client.EnumerateApiResourcesAsync<Pokemon>())
{
    Console.WriteLine($"{pokemonRef.Id}: {pokemonRef.Name}");
}
```

### Create client with in-memory caching
```csharp
using Microsoft.Extensions.Caching.Memory;
using PokeApi.V2;

MemoryCache memoryCache = new(new MemoryCacheOptions());
PokeApiClient client = new(memoryCache);

var pokemon = await client.GetApiResourceAsync<Pokemon>(25); // Get Pokémon with ID 25 (Pikachu) with caching
```

### Register client with Redis caching with Aspire
```csharp
using PokeApi.V2;

var builder = Host.CreateApplicationBuilder(args);

builder.AddServiceDefaults();

builder.AddRedisDistributedCache("distributed-cache");

builder.Services.AddSingleton<PokeApiClient>();
```
