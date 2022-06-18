using Newtonsoft.Json;

namespace api.Models;

public class GetPokemonByIDDto
{
     [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
}