using DFAPolar.Domain.Interfaces;
using DFAPolar.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DFAPolar.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _config;
        private readonly IRepositoryWork _repositoryWork;

        public UserService(IConfiguration config, IRepositoryWork repositoryWork)
        {
            _config = config;
            _repositoryWork = repositoryWork;
        }

        public async Task<UserModel> Authenticate(string email, string password)
        {
            return await _repositoryWork.Users.Authenticate(email, password);
        }

        public async Task<UserModel> Create(UserModel user, string password)
        {
            await _repositoryWork.Users.Create(user, password);

            await _repositoryWork.CommitAsync();
            return user;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> GetById(int id)
        {
            return await _repositoryWork.Users.GetWithUsersByIdAsync(id);
        }

        public void Update(UserModel user, string password = null)
        {
            throw new NotImplementedException();
        }

        public string GenerateJWTToken(UserModel user)
        {
            return _repositoryWork.Users.GenerateJWTToken(user);
        }

    }
}
