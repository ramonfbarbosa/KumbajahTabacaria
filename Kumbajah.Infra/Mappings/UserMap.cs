using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TAB_CLIENTES");

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
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.LastName)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("SOBRENOME")
               .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("EMAIL")
                .HasColumnType("VARCHAR(120)");

            builder.Property(x => x.Birthdate)
                .IsRequired()
                .HasColumnName("DT_ANIVERSARIO")
                .HasColumnType("DATE");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("SENHA")
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.CPF)
                .HasMaxLength(11)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR(20)");

            builder.Property(x => x.PhoneNumber)
                .HasColumnName("CELULAR")
                .HasColumnType("VARCHAR(20)");

        }
    }
}
