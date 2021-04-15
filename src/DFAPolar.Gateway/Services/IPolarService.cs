using DFAPolar.Gateway.Models;
using System.Threading.Tasks;

namespace DFAPolar.Gateway.Services
{
    public interface IPolarService
    {
        Task<PolarTokenModel> GetToken();

        Task<ActivityModel> GetActivities(string authToken);
    }
}
