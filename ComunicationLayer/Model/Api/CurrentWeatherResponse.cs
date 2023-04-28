using ComunicationLayer.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicationLayer.Model.api
{
    public class CurrentWeatherResponse
    {
        [JsonProperty("coord")]
        public Coordinate Coordinates { get; set; }
        [JsonProperty("weather")]
        public Weather[] Weathers { get; set; }
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public int Visibillity { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("rain")]
        public Rain Rain { get; set; }
        [JsonProperty("snow")]
        public Snow Snow { get; set; }
        [JsonProperty("clouds")]
        public Cloud Cloud { get; set; }
        [JsonProperty("dt")]
        public int Dt { get; set; }
        [JsonProperty("sys")]
        public Sys Sys { get; set; }
        [JsonProperty("timezone")]
        public int Timezone { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public int Cod { get; set; }
        [JsonProperty("pop")]
        public double Pop { get; set; }
        [JsonProperty("dt_text")]
        public string DtText { get; set; }

        public override string? ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
