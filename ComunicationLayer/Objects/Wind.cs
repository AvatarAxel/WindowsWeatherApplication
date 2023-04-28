using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicationLayer.Objects
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public double Degrees { get; set; }
        [JsonProperty("gust")]
        public double Gust { get; set; }
    }
}
