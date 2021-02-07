using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using CitiesBR.Infrastructure.DependencyInjection;

namespace CitiesBR.API
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
            RegisterServices(services, Configuration);
            services.AddControllers();

            AddSwagger(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(options => {

                options.DocumentTitle = "API Cidades Br";

                //options.SwaggerEndpoint("../swagger/v1/swagger.json", "v1");

                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

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

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var contato = new OpenApiContact() 
                { 
                    Name = "Igor Freitas Couto",
                    Email = "igor.fcouto@gmail.com",
                    Url = new Uri("https://github.com/igor-couto/cities-br-api") 
                };

                var licenca = new OpenApiLicense()
                {
                   Name = "Licença Apache 2.0",
                   Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.html")
                };

                options.SwaggerDoc("v1", 
                    new OpenApiInfo { 
                        Title = "API Cidades Br", 
                        Version = "1.0", 
                        Description = "API de Cidades do Brasil", 
                        Contact = contato,
                        License = licenca
                    });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                if (File.Exists(xmlPath))
                    options.IncludeXmlComments(xmlPath);
            });
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            DependencyInjector.RegisterServices(services, configuration);
        }
    }
}
