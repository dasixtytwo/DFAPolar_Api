using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DFAPolar.Gateway.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace DFAPolar.Gateway.Gateways
{
    public class PolarRemoteGateway : IPolarRemoteGateway
    {

        private readonly HttpClient _client;
        private readonly IOptions<PolarApiConfiguration> _configuration;

        public PolarRemoteGateway(HttpClient client, IOptions<PolarApiConfiguration> configuration)
        {
            _client = client;
            _configuration = configuration;
            SetUpClient();
        }

        public async Task<T> ProcessGetRequest<T>(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public async Task<T> ProcessPostRequest<T>(string endpoint, HttpContent content)
        {
            var response = await _client.PostAsync(endpoint, content);
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public void BasicAuthorization()
        {
            var byteArray = Encoding.ASCII.GetBytes($"{_configuration.Value.ClientId}:{_configuration.Value.ClientSecret}");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public void BearerAuthorization(string authToken)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        }

        private void SetUpClient()
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Application.Json));
            _client.BaseAddress = new Uri(_configuration.Value.PolarApiEndpoint);
        }
    }
}

