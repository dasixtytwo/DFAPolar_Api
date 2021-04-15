using System.Collections.Generic;
using Newtonsoft.Json;

namespace DFAPolar.Gateway.Models
{
    public class ActivityZonesSampleModel
    {
        [JsonProperty(PropertyName = "samples")]
        public IEnumerable<ActivityZonesModel> Samples { get; set; }

        [JsonProperty(PropertyName = "interval")]
        public int Interval { get; set; }
    }
}
