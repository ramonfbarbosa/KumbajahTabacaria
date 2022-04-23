using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");


            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("description")
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("price")
                .HasColumnType("DECIMAL");

            builder.Property(x => x.Image)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("image")
                .HasColumnType("BLOB");

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("quantity")
                .HasColumnType("BIGINT");

            builder.Property(x => x.Category)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("birthday")
                .HasColumnType("VARCHAR(10)");

            // falta relacionamento Category

        }
    }
}
