using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Kumbajah.Infra.Context
{
    public class KumbajahContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        public KumbajahContext() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasOne(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId);

            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new ProductMap());
        }
    }
}
