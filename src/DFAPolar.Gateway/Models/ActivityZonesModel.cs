using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DFAPolar.Gateway.Models
{
    public class ActivityZonesModel
    {
        [JsonProperty(PropertyName = "activity-zones")]
        public IEnumerable<ActivityZoneModel> ActivityZones { get; set; }

        [JsonProperty(PropertyName = "time")]
        public TimeSpan Time { get; set; }
    }
}
