using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace CitiesBR.Infrastructure.DependencyInjection.Registers
{
    public static class SwaggerRegister
    {
        public static void RegisterServices(IServiceCollection services)
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
    }
}