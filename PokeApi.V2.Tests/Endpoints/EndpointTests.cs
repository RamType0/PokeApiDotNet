namespace PokeApi.V2.Tests.Endpoints;

public class BerryTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Berry>(fixture, "cheri");
public class BerryFirmnessTests(PokeApiClientFixture fixture) : NamedApiResourceTests<BerryFirmness>(fixture, "very-soft");

public class ContestTypeTests(PokeApiClientFixture fixture) : NamedApiResourceTests<ContestType>(fixture, "cool");
public class ContestEffectTests(PokeApiClientFixture fixture) : ApiResourceTests<ContestEffect>(fixture);
public class SuperContestEffectTests(PokeApiClientFixture fixture) : ApiResourceTests<ContestEffect>(fixture);
public class EncounterMethodTests(PokeApiClientFixture fixture) : NamedApiResourceTests<EncounterMethod>(fixture, "walk");
public class EncounterConditionTests(PokeApiClientFixture fixture) : NamedApiResourceTests<EncounterCondition>(fixture, "swarm");
public class EncounterConditionValueTests(PokeApiClientFixture fixture) : NamedApiResourceTests<EncounterConditionValue>(fixture, "swarm-yes");

public class EvolutionChainTests(PokeApiClientFixture fixture) : ApiResourceTests<EvolutionChain>(fixture);
public class EvolutionTriggerTests(PokeApiClientFixture fixture) : NamedApiResourceTests<EvolutionTrigger>(fixture, "level-up");
public class GenerationTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Generation>(fixture, "generation-i");
public class PokedexTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Pokedex>(fixture, "national");
public class VersionTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Version>(fixture, "red");
public class VersionGroupTests(PokeApiClientFixture fixture) : NamedApiResourceTests<VersionGroup>(fixture, "red-blue");
public class ItemTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Item>(fixture, "master-ball");
public class ItemAttributeTests(PokeApiClientFixture fixture) : NamedApiResourceTests<ItemAttribute>(fixture, "countable");
public class ItemCategoryTests(PokeApiClientFixture fixture) : NamedApiResourceTests<ItemCategory>(fixture, "stat-boosts");
public class ItemFlingEffectTests(PokeApiClientFixture fixture) : NamedApiResourceTests<ItemFlingEffect>(fixture, "badly-poison");
public class ItemPocketTests(PokeApiClientFixture fixture) : NamedApiResourceTests<ItemPocket>(fixture, "misc");
public class LocationTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Location>(fixture, "canalave-city");
public class LocationAreaTests(PokeApiClientFixture fixture) : NamedApiResourceTests<LocationArea>(fixture, "canalave-city-area");
public class PalParkAreaTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PalParkArea>(fixture, "forest");
public class RegionTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Region>(fixture, "kanto");


public class MachineTests(PokeApiClientFixture fixture) : ApiResourceTests<Machine>(fixture);

public class MoveTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Move>(fixture, "pound");
public class MoveAilmentTests(PokeApiClientFixture fixture) : NamedApiResourceTests<MoveAilment>(fixture, "unknown");
public class MoveBattleStyleTests(PokeApiClientFixture fixture) : NamedApiResourceTests<MoveBattleStyle>(fixture, "attack");
public class MoveCategoryTests(PokeApiClientFixture fixture) : NamedApiResourceTests<MoveCategory>(fixture, "damage");
public class MoveDamageClassTests(PokeApiClientFixture fixture) : NamedApiResourceTests<MoveDamageClass>(fixture, "status");
public class MoveLearnMethodTests(PokeApiClientFixture fixture) : NamedApiResourceTests<MoveLearnMethod>(fixture, "level-up");
public class MoveTargetTests(PokeApiClientFixture fixture) : NamedApiResourceTests<MoveTarget>(fixture, "specific-move");

public class AbilityTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Ability>(fixture, "stench");
public class CharacteristicTests(PokeApiClientFixture fixture) : ApiResourceTests<Characteristic>(fixture);
public class EggGroupTests(PokeApiClientFixture fixture) : NamedApiResourceTests<EggGroup>(fixture, "monster");
public class GenderTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Gender>(fixture, "female");
public class GrowthRateTests(PokeApiClientFixture fixture) : NamedApiResourceTests<GrowthRate>(fixture, "slow");
public class NatureTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Nature>(fixture, "hardy");
public class PokeathlonStatTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PokeathlonStat>(fixture, "speed");

public class PokemonTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Pokemon>(fixture, "bulbasaur");
public class PokemonEncountersTests(PokeApiClientFixture fixture) : NamedApiResourcePropertyTests<Pokemon, PokemonEncounters>(fixture, "bulbasaur");
public class PokemonColorTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PokemonColor>(fixture, "black");
public class PokemonFormTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PokemonForm>(fixture, "bulbasaur");
public class PokemonHabitatTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PokemonHabitat>(fixture, "cave");
public class PokemonShapeTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PokemonShape>(fixture, "ball");
public class PokemonSpeciesTests(PokeApiClientFixture fixture) : NamedApiResourceTests<PokemonSpecies>(fixture, "bulbasaur");
public class StatTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Stat>(fixture, "hp");
public class TypeTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Type>(fixture, "normal");
public class LanguageTests(PokeApiClientFixture fixture) : NamedApiResourceTests<Language>(fixture, "ja-hrkt");
