using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PokeApi.V2;

[JsonConverter(typeof(PokemonEncountersJsonConverter))]
public record PokemonEncounters : INamedApiResourceProperty<Pokemon, PokemonEncounters>
{
    public static string RelativePath => "encounters";
    public required ImmutableArray<LocationAreaEncounter> Encounters { get; init; }
    public sealed class PokemonEncountersJsonConverter : JsonConverter<PokemonEncounters>
    {
        public override PokemonEncounters Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            var encounters = JsonSerializer.Deserialize<ImmutableArray<LocationAreaEncounter>>(ref reader, options);
            return new PokemonEncounters
            {
                Encounters = encounters
            };
        }
        public override void Write(Utf8JsonWriter writer, PokemonEncounters value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Encounters, options);
        }
    }
}
