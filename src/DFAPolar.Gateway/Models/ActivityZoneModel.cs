using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace DFAPolar.Gateway.Models
{
    public class ActivityZoneModel
    {
        [JsonProperty(PropertyName = "index")]
        public int Index { get; set; }

        [JsonProperty(PropertyName = "inzone")]
        public TimeSpan InZone { get; set; }
    }
}
