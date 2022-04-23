using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Kumbajah.Infra.Context
{
    public class KumbajahContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public KumbajahContext() { }

        public KumbajahContext(IConfiguration config) 
        { 
            _configuration = config;
        }
        public KumbajahContext(DbContextOptions<KumbajahContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            var connString = _configuration.GetConnectionString("DefaultConnection");
            optionsbuilder.UseSqlServer(connString);
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new ProductMap());
        }
    }
}
