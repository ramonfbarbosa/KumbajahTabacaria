using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TB_USERS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1, 1)
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("NAME")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.LastName)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("LAST_NAME")
               .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("EMAIL")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Birthdate)
                .IsRequired()
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("PASSWORD")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.CPF)
                .HasMaxLength(11)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasColumnType("VARCHAR(80)");

        }
    }
}
