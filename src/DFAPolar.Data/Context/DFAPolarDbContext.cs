using Microsoft.EntityFrameworkCore;
using DFAPolar.Domain.Models;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore.Storage;

namespace DFAPolar.Data.Context
{
    public class DFAPolarDbContext : DbContext, IDFAPolarDbContext
    {
        public DFAPolarDbContext(DbContextOptions<DFAPolarDbContext> opts) 
            : base(opts) { }

        // Defining DbSet
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(150)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DFAPolarDbContext).Assembly);

            // disable the cascade deletion
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;


            base.OnModelCreating(modelBuilder);
        }
    }
}
