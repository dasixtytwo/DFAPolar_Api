using System.Net.Http;
using System.Threading.Tasks;

namespace DFAPolar.Gateway.Gateways
{
    public interface IPolarGateway
    {
        Task<T> ProcessPostRequest<T>(string endpoint, HttpContent content);

        void BasicAuthorization();

        void BearerAuthorization(string authToken);

        Task<T> ProcessGetRequest<T>(string endpoint);
    }
}
