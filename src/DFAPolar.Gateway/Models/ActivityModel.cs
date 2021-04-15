using System;
using Newtonsoft.Json;

namespace DFAPolar.Gateway.Models
{
    public class ActivityModel: EntityModel
    {
        [JsonProperty(PropertyName = "id")]
        public string DailyActivityId { get; set; }

        [JsonProperty(PropertyName = "polar-user")]
        public string PolarUser { get; set; }

        [JsonProperty(PropertyName = "transaction-id")]
        public int TransactionId { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty(PropertyName = "calories")]
        public int Calories { get; set; }

        [JsonProperty(PropertyName = "active-calories")]
        public int ActiveCalories { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public TimeSpan Duration { get; set; }

        [JsonProperty(PropertyName = "active-steps")]
        public int ActiveSteps { get; set; }

        public StepSamplesModel StepSamples { get; set; }

        public ActivityZonesSampleModel ActivityZonesSamples { get; set; }
    }
}
