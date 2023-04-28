using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicationLayer.Objects
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
        [JsonProperty("feels_like")]
        public double Feeling { get; set; }
        [JsonProperty("temp_min")]
        public double TempMin { get; set; }
        [JsonProperty("temp_max")]
        public double TempMax { get; set; }
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("sea_level")]
        public int SeaLevel { get; set; }
        [JsonProperty("grnd_level")]
        public int GroundLevel { get; set; }
        [JsonProperty("temp_kf")]
        public double TemKf { get; set; }
    }
}
