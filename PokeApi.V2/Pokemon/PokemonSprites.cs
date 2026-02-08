using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

public record PokemonSprites
{
    /// <summary>
    /// The default depiction of this Pokémon from the front in battle.
    /// </summary>
    [JsonPropertyName("front_default")]
    [Description("The default depiction of this Pokémon from the front in battle.")]
    public required Uri? FrontDefault { get; init; }
    /// <summary>
    /// The shiny depiction of this Pokémon from the front in battle.
    /// </summary>
    [JsonPropertyName("front_shiny")]
    [Description("The shiny depiction of this Pokémon from the front in battle.")]
    public required Uri? FrontShiny { get; init; }
    /// <summary>
    /// The female depiction of this Pokémon from the front in battle.
    /// </summary>
    [JsonPropertyName("front_female")]
    [Description("The female depiction of this Pokémon from the front in battle.")]
    public required Uri? FrontFemale { get; init; }
    /// <summary>
    /// The shiny female depiction of this Pokémon from the front in battle.
    /// </summary>
    [JsonPropertyName("front_shiny_female")]
    [Description("The shiny female depiction of this Pokémon from the front in battle.")]
    public required Uri? FrontShinyFemale { get; init; }
    /// <summary>
    /// The default depiction of this Pokémon from the back in battle.
    /// </summary>
    [JsonPropertyName("back_default")]
    [Description("The default depiction of this Pokémon from the back in battle.")]
    public required Uri? BackDefault { get; init; }
    /// <summary>
    /// The shiny depiction of this Pokémon from the back in battle.
    /// </summary>
    [JsonPropertyName("back_shiny")]
    [Description("The shiny depiction of this Pokémon from the back in battle.")]
    public required Uri? BackShiny { get; init; }
    /// <summary>
    /// The female depiction of this Pokémon from the back in battle.
    /// </summary>
    [JsonPropertyName("back_female")]
    [Description("The female depiction of this Pokémon from the back in battle.")]
    public required Uri? BackFemale { get; init; }
    /// <summary>
    /// The shiny female depiction of this Pokémon from the back in battle.
    /// </summary>
    [JsonPropertyName("back_shiny_female")]
    [Description("The shiny female depiction of this Pokémon from the back in battle.")]
    public required Uri? BackShinyFemale { get; init; }
}
