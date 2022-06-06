using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TB_PRODUCTS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
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
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.CategoryId)
                .IsRequired();
            builder.Property(x => x.BrandId)
               .IsRequired();
            builder.Property(x => x.StockId)
               .IsRequired();
        }
    }
}
