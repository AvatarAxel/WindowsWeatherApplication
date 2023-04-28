using ComunicationLayer.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicationLayer.Model.api
{
    public class NearbyWeatherResponse
    {
        [JsonProperty("cod")]
        public int Cod { get; set; }
        [JsonProperty("message")]
        public int Message { get; set; }
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        [JsonProperty("list")]
        public List<CurrentWeatherResponse> ListCurrentWeather { get; set; }
        [JsonProperty("city")]
        public City City { get; set; }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
