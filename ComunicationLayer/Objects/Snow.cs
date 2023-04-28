using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunicationLayer.Objects
{
    public class Snow
    {
        [JsonProperty("1h")]
        public double OneHour { get; set; }
        [JsonProperty("3h")]
        public double ThreeHours { get; set; }
    }
}
