using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CrossCut
{
    public class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            var dataBaseConif = new MongoDbConfig();
            configuration.Bind(dataBaseConif);

            var mongoDbContext = new MongoDbContext();

            var repository = new BaseRepository<IEntity>(mongoDbContext);
            services.AddSingleton<IRepository<IEntity>>(repository);

            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICityService, CityService>();
        }
    }
}