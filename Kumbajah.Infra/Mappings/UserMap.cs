using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name + " " + x.LastName)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("email")
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("cpf")
                .HasColumnType("VARCHAR(11)");

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("phone_number")
                .HasColumnType("BIGINT");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("password")
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.Age)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("age")
                .HasColumnType("INT");

        }
    }
}
