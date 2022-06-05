using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Kumbajah.Infra.Context
{
    public class KumbajahContext : DbContext
    {
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<OrderItem> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<DefaultAddress> DefaultAddress { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<User> Users { get; set; }

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
            builder.ApplyConfiguration(new DefaultAddressMap());
            builder.ApplyConfiguration(new OrderMap());
            builder.ApplyConfiguration(new OrderItemMap());
            builder.ApplyConfiguration(new OrderStatusMap());
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new StockMap());
            builder.ApplyConfiguration(new UserMap());
        }

        private static void EntityRelationship(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasOne(order => order.Address)
                .WithMany(address => address.Orders)
                .HasForeignKey(order => order.AddressId);
            builder.Entity<Order>()
                 .HasOne(order => order.Users)
                 .WithMany(client => client.Orders)
                 .HasForeignKey(order => order.UserId);
            builder.Entity<Order>()
                 .HasOne(order => order.OrderStatus)
                 .WithMany(orderStatus => orderStatus.Orders)
                 .HasForeignKey(order => order.OrderStatusId);

            builder.Entity<Product>()
                .HasOne(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId);
            builder.Entity<Product>()
                .HasOne(product => product.Brand)
                .WithMany(brand => brand.Products)
                .HasForeignKey(product => product.BrandId);
            builder.Entity<Product>()
                .HasOne(product => product.Stock)
                .WithMany(stock => stock.Products)
                .HasForeignKey(product => product.StockId);

            builder.Entity<OrderItem>()
                .HasOne(orderItem => orderItem.Product)
                .WithMany(product => product.Items)
                .HasForeignKey(orderItem => orderItem.ProductId);
            builder.Entity<OrderItem>()
                .HasOne(orderItem => orderItem.Order)
                .WithMany(order => order.Items)
                .HasForeignKey(orderItem => orderItem.OrderId);

            builder.Entity<User>()
                .HasOne(user => user.DefaultAddress)
                .WithMany(defaltAddress => defaltAddress.Users)
                .HasForeignKey(user => user.DefaultAddressId);
        }
    }
}
