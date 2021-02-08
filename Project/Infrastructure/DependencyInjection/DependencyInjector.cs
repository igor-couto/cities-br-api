using CitiesBr.Infrastructure.DependencyInjection.Registers;
using CitiesBR.Infrastructure.DependencyInjection.Registers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CitiesBR.Infrastructure.DependencyInjection
{
    public static class DependencyInjector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            SwaggerRegister.RegisterServices(services);
            MongoDbRegister.RegisterServices(services, configuration);
            ServicesRegister.RegisterServices(services);
        }
    }
}