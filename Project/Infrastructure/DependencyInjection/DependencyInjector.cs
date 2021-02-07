using CitiesBR.Application.Interfaces;
using CitiesBR.Application.Services;
using CitiesBR.Domain.Interfaces;
using CitiesBR.Infrastructure.Persistence.Database;
using CitiesBR.Infrastructure.Persistence.Repository;
using CitiesBR.Infrastructure.Presistence.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CitiesBR.Infrastructure.DependencyInjection
{
    public static class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // var dataBaseConif = new MongoDbConfig();
            // configuration.Bind(dataBaseConif);

            var mongoDbContext = new MongoDbContext();

            var repository = new BaseRepository<IEntity>(mongoDbContext);
            services.AddSingleton<IRepository<IEntity>>(repository);

            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICityService, CityService>();
        }
    }
}