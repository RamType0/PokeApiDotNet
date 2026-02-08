using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record Berry : INamedApiResource<Berry>
{
    public static string EndpointPath => "berry";
    /// <summary>
    /// The identifier for this resource.
    /// </summary>
    [JsonPropertyName("id")]
    [Description("The identifier for this resource.")]
    public required int Id { get; init; }
    /// <summary>
    /// The name for this resource.
    /// </summary>
    [JsonPropertyName("name")]
    [Description("The name for this resource.")]
    public required string Name { get; init; }
    /// <summary>
    /// Time it takes the tree to grow one stage, in hours. Berry trees go through four of these growth stages before they can be picked.
    /// </summary>
    [JsonPropertyName("growth_time")]
    [Description("Time it takes the tree to grow one stage, in hours. Berry trees go through four of these growth stages before they can be picked.")]
    public required int GrowthTime { get; init; }

    /// <summary>
    /// The maximum number of these berries that can grow on one tree in Generation IV.
    /// </summary>
    [JsonPropertyName("max_harvest")]
    [Description("The maximum number of these berries that can grow on one tree in Generation IV.")]
    public required int MaxHarvest { get; init; }

    /// <summary>
    /// The power of the move "Natural Gift" when used with this Berry.
    /// </summary>
    [JsonPropertyName("natural_gift_power")]
    [Description("The power of the move \"Natural Gift\" when used with this Berry.")]
    public required int NaturalGiftPower { get; init; }

    /// <summary>
    /// The size of this Berry, in millimeters.
    /// </summary>
    [JsonPropertyName("size")]
    [Description("The size of this Berry, in millimeters.")]
    public required int Size { get; init; }

    /// <summary>
    /// The smoothness of this Berry, used in making Pokéblocks or Poffins.
    /// </summary>
    [JsonPropertyName("smoothness")]
    [Description("The smoothness of this Berry, used in making Pokéblocks or Poffins.")]
    public required int Smoothness { get; init; }

    /// <summary>
    /// The speed at which this Berry dries out the soil as it grows. A higher rate means the soil dries more quickly.
    /// </summary>
    [JsonPropertyName("soil_dryness")]
    [Description("The speed at which this Berry dries out the soil as it grows. A higher rate means the soil dries more quickly.")]
    public required int SoilDryness { get; init; }

    /// <summary>
    /// The firmness of this berry, used in making Pokéblocks or Poffins.
    /// </summary>
    [JsonPropertyName("firmness")]
    [Description("The firmness of this berry, used in making Pokéblocks or Poffins.")]
    public required NamedApiResourceReference<BerryFirmness> Firmness { get; init; }

    /// <summary>
    /// A list of references to each flavor a berry can have and the potency of each of those flavors in regard to this berry.
    /// </summary>
    [JsonPropertyName("flavors")]
    [Description("A list of references to each flavor a berry can have and the potency of each of those flavors in regard to this berry.")]
    public required ImmutableArray<BerryFlavorMap> Flavors { get; init; }

    /// <summary>
    /// Berries are actually items. This is a reference to the item specific data for this berry.
    /// </summary>
    [JsonPropertyName("item")]
    [Description("Berries are actually items. This is a reference to the item specific data for this berry.")]
    public required NamedApiResourceReference<Item> Item { get; init; }

    /// <summary>
    /// The type inherited by "Natural Gift" when used with this Berry.
    /// </summary>
    [JsonPropertyName("natural_gift_type")]
    [Description("The type inherited by \"Natural Gift\" when used with this Berry.")]
    public required NamedApiResourceReference<Type> NaturalGiftType { get; init; }
}
