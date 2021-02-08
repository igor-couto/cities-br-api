using CitiesBR.Application.Interfaces;
using CitiesBR.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CitiesBr.Infrastructure.DependencyInjection.Registers
{
    public static class ServicesRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICityService, CityService>();
        }
    }
}