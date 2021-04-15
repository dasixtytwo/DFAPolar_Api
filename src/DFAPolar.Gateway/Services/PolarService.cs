using DFAPolar.Gateway.Models;
using System;
using System.Threading.Tasks;

namespace DFAPolar.Gateway.Services
{
    public class PolarService : IPolarService
    {
        public Task<ActivityModel> GetActivities(string authToken)
        {
            throw new NotImplementedException();
        }

        public Task<PolarTokenModel> GetToken()
        {
            throw new NotImplementedException();
        }
    }
}
