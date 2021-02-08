using CitiesBR.Domain.Interfaces;
using CitiesBR.Infrastructure.Persistence.Database;
using CitiesBR.Infrastructure.Persistence.Repository;
using CitiesBR.Infrastructure.Presistence.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace CitiesBR.Infrastructure.DependencyInjection.Registers
{
    public static class MongoDbRegister
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            var mongoDbContext = new MongoDbContext(configuration);
            var repository = new BaseRepository<IEntity>(mongoDbContext);
            
            services.AddSingleton<IRepository<IEntity>>(repository);
            services.AddSingleton<ICityRepository, CityRepository>();
        }
    }
}
