using System.Collections.Generic;
using Newtonsoft.Json;

namespace DFAPolar.Gateway.Models
{
    public class StepSamplesModel
    {
        [JsonProperty(PropertyName = "interval")]
        public int Interval { get; set; }

        [JsonProperty(PropertyName = "samples")]
        public IEnumerable<StepSampleModel> Samples { get; set; }
    }
}
