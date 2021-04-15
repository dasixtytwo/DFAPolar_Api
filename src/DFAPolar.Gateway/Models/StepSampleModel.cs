using System;
using Newtonsoft.Json;

namespace DFAPolar.Gateway.Models
{
    public class StepSampleModel
    {
        [JsonProperty(PropertyName = "steps")]
        public int Steps { get; set; }

        [JsonProperty(PropertyName = "time")]
        public TimeSpan Time { get; set; }
    }
}
