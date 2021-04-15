using DFAPolar.Domain.Interfaces;
using DFAPolar.Data.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DFAPolar.Data.Repositories
{
    public class RepositoryWork : IRepositoryWork
    {
        private readonly DFAPolarDbContext _dbContext;
        private readonly IConfiguration _config;
        private IUserRepository _userRepository;

        public RepositoryWork(DFAPolarDbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_dbContext, _config);

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
