using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CitiesBR.Infrastructure.DependencyInjection;

namespace CitiesBR.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            DependencyInjector.RegisterServices(services, Configuration);
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(options => {

                options.DocumentTitle = "API Cidades Br";

                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); // "../swagger/v1/swagger.json", "v1"

                options.RoutePrefix = string.Empty;

                options.InjectStylesheet("../custom.css");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}