using Newtonsoft.Json;
using System.Collections.Generic;

namespace NecnatAbp.Br.GeGeocodificacao.DmGoogleGeocoding
{
    public class GgAddressComponent
    {
        [JsonProperty("long_name")]
        public string? LongName { get; set; }

        [JsonProperty("short_name")]
        public string? ShortName { get; set; }

        [JsonProperty("types")]
        public List<string>? Types { get; set; }
    }
}
