using DFAPolar.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DFAPolar.Data.Context
{
    public interface IDFAPolarDbContext
    {
        public DbSet<UserModel> Users { get; set; }

        int SaveChanges();
    }
}
