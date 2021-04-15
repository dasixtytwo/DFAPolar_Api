using DFAPolar.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DFAPolar.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName)
                   .IsRequired()
                   .HasColumnType("varchar(30)");

            builder.Property(u => u.LastName)
                   .IsRequired()
                   .HasColumnType("varchar(30)");

            builder.Property(u => u.UserEmail)
                   .IsRequired()
                   .HasColumnType("varchar(150)");

            builder.Property(u => u.PhoneOne)
                   .IsRequired()
                   .HasColumnType("varchar(15)");

            builder.Property(u => u.PhoneTwo)
                   .IsRequired()
                   .HasColumnType("varchar(15)");

            builder.Property(u => u.Country)
                   .IsRequired()
                   .HasColumnType("varchar(30)");

            builder.Property(u => u.OfAge)
                   .IsRequired()
                   .HasColumnType("bit");

            builder.Property(u => u.UserRole)
                   .IsRequired()
                   .HasColumnType("varchar(10)")
                   .HasDefaultValue("User");

            builder.ToTable("Users");
        }
    }
}
