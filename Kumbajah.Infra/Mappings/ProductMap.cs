using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("NAME")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnName("PRICE")
                .HasColumnType("DECIMAL(10,10)");

            builder.Property(x => x.Image)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("IMAGE")
                .HasColumnType("BLOB");

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnName("QUANTITY")
                .HasColumnType("BIGINT");

            builder.Property(x => x.CategoryId)
                .IsRequired()
                .HasColumnName("CATEGORY_ID")
                .HasColumnType("INT");

        }
    }
}
