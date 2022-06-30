using Kumbajah.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kumbajah.Infra.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TAB_PRODUTOS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("NOME")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("DESCRICAO")
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnName("PRECO")
                .HasColumnType("DECIMAL(10,10)");

            builder.Property(x => x.Image)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("IMAGEM")
                .HasColumnType("VARCHAR(180)");

            builder.Property(x => x.BrandId)
                .IsRequired()
                .HasColumnName("BRAND_ID")
                .HasColumnType("INT");

            builder.Property(x => x.StockId)
                .IsRequired()
                .HasColumnName("STOCK_ID")
                .HasColumnType("INT");

            builder.Property(x => x.CategoryId)
                .IsRequired()
                .HasColumnName("CATEGORY_ID")
                .HasColumnType("INT");

            builder.Property(x => x.ColorId)
                .IsRequired()
                .HasColumnName("COLOR_ID")
                .HasColumnType("INT");
        }
    }
}
