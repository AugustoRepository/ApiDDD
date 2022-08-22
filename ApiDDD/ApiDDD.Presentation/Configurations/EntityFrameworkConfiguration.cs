using ApiDDD.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ApiDDD.Presentation.Configurations
{
    public class EntityFrameworkConfiguration
    {
        public static void ConfigurationServices(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DbDDD");

            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(connectionString));
        }

        
    }
}
