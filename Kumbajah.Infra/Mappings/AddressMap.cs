using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("TB_ADDRESSES");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.CEP)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR(15)");

            builder.Property(x => x.Street)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("STREET")
                .HasColumnType("VARCHAR(60)");

            builder.Property(x => x.State)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("STATE")
                .HasColumnType("VARCHAR(20)");

            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("CITY")
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.District)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("DISTRICT")
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Number)
                .IsRequired()
                .HasColumnName("NUMBER")
                .HasColumnType("INT");

            builder.Property(x => x.Complement)
                .HasMaxLength(20)
                .HasColumnName("COMPLEMENT")
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Reference)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("REFERENCE")
                .HasColumnType("VARCHAR(80)");
        }
    }
}
