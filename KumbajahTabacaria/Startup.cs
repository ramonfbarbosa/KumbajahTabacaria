using Kumbajah.Infra.Context;
using Kumbajah.Infra.Interfaces;
using Kumbajah.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Data;

namespace KumbajahTabacaria
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("KUMBAJAH_MANAGER");
            services.AddTransient<IDbConnection>(conn => new SqlConnection(connectionString));
            services.AddDbContext<KumbajahContext>(options =>
            {
                options.UseSqlServer(connectionString, conn => conn.MigrationsAssembly("KumbajahTabacaria"));
                options.UseLazyLoadingProxies();
            });
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            //string viacepApiKey = Configuration.GetSection("ViaCepService:ViaCepURL").Value;
            //services.AddHttpClient<ViaCepService>(client =>
            //{
            //    client.DefaultRequestHeaders.Add("Accept", "application/json");
            //    client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", viacepApiKey);
            //});
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });//testar
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KumbajahTabacaria", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "KumbajahTabacaria v1"));
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
