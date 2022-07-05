using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Kumbajah.Infra.Context
{
    public class KumbajahContext : DbContext
    {
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AddressUser> UserAddress { get; set; }

        public KumbajahContext() { }

        public KumbajahContext(DbContextOptions<KumbajahContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            EntityRelationship(builder);
            EntityMapper(builder);
        }

        private static void EntityMapper(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AddressMap());
            builder.ApplyConfiguration(new BrandMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new ColorMap());
            builder.ApplyConfiguration(new OrderMap());
            builder.ApplyConfiguration(new OrderItemMap());
            builder.ApplyConfiguration(new OrderStatusMap());
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new StockMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserAddressMap());
        }

        private static void EntityRelationship(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(order => order.Address)
                .WithOne(address => address.Order)
                .HasForeignKey<Order>(order => order.AddressId);
            builder.Entity<Order>()
                .HasOne(order => order.User)
                .WithMany(client => client.Orders)
                .HasForeignKey(order => order.UserId);
            builder.Entity<Order>()
                .HasOne(order => order.OrderStatus)
                .WithMany(orderStatus => orderStatus.Orders)
                .HasForeignKey(order => order.OrderStatusId);
            builder.Entity<Order>()
                .HasMany(orderItem => orderItem.Items)
                .WithOne(order => order.Order)
                .HasForeignKey(orderItem => orderItem.OrderId);

            builder.Entity<Product>()
                .HasOne(product => product.Stock)
                .WithOne(stock => stock.Product)
                .HasForeignKey<Product>(product => product.StockId);
            builder.Entity<Product>()
                .HasOne(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId);
            builder.Entity<Product>()
                .HasOne(product => product.Brand)
                .WithMany(brand => brand.Products)
                .HasForeignKey(product => product.BrandId);
            builder.Entity<Product>()
                .HasOne(product => product.Color)
                .WithMany(color => color.Products)
                .HasForeignKey(product => product.ColorId);
            builder.Entity<Product>()
                .HasMany(product => product.Items)
                .WithOne(orderItem => orderItem.Product)
                .HasForeignKey(orderItem => orderItem.ProductId);

            builder.Entity<AddressUser>()
                .HasOne(userAddress => userAddress.User)
                .WithMany(user => user.UserAddress)
                .HasForeignKey(userAddress => userAddress.UserId);
            builder.Entity<AddressUser>()
                .HasOne(userAddress => userAddress.Address)
                .WithMany(user => user.UserAddress)
                .HasForeignKey(userAddress => userAddress.UserId);
        }
    }
}
