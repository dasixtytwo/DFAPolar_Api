using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DFAPolar.Gateway.Gateways
{
    public class PolarGateway : IPolarGateway
    {
        public void BasicAuthorization()
        {
            throw new NotImplementedException();
        }

        public void BearerAuthorization(string authToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> ProcessGetRequest<T>(string endpoint)
        {
            throw new NotImplementedException();
        }

        public Task<T> ProcessPostRequest<T>(string endpoint, HttpContent content)
        {
            throw new NotImplementedException();
        }
    }
}
