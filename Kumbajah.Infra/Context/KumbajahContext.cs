using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}
