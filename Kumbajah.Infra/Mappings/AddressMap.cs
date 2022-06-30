using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("TAB_ENDERECOS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.CEP)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR(20)");

            builder.Property(x => x.Street)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("RUA")
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(x => x.State)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("ESTADO")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CIDADE")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.District)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("BAIRRO")
                .HasColumnType("VARCHAR(2)");

            builder.Property(x => x.Number)
                .IsRequired()
                .HasColumnName("NUMERO")
                .HasColumnType("INT");

            builder.Property(x => x.Complement)
                .HasMaxLength(20)
                .HasColumnName("COMPLEMENTO")
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(x => x.Reference)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("REFERENCIA")
                .HasColumnType("VARCHAR(MAX)");
        }
    }
}
