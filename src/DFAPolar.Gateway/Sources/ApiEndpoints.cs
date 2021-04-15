namespace DFAPolar.Gateway.Sources
{
    public static class ApiEndpoints
    {
        public const string Notifications = "/v3/notifications";
        public const string CreateTransaction = "/v3/users/{0}/{1}";
        public const string CommitTransaction = "/v3/users/{0}/{1}/{2}";
        public const string Token = "/v2/oauth2/token";
        public const string StepSamples = "/step-samples";
        public const string ZoneSamples = "/zone-samples";
        public const string HeartRateZones = "/heart-rate-zones";
        public const string AvailableSamples = "/samples";
        public const string NightlyRecharge = "/v3/users/nightly-recharge";
        public const string Sleep = "/v3/users/sleep";
    }
}
