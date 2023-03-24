using FichasAndDragons.Infra.Configs;
using FichasAndDragons.Infra.Configs.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Ioc
{
    public static class ConfigureContainers
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetSection("DatabaseConfig:ConnectionString").Value;
            string databaseName = configuration.GetSection("DatabaseConfig:DatabaseName").Value;

            services.AddScoped<IMongoDatabaseConfiguration>(x => MongoDatabaseFluent.Configure().ConfigureClient(connectionString).ConfigureDatabaseName(databaseName));

        }
    }
}
