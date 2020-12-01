using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.IO;

namespace estimador.api.Config
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "estimador.api.xml");

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V1", new OpenApiInfo { Title = "Estimador Api V1", Version = "V1" });
                c.IncludeXmlComments(xmlPath);
            }
            );

            return services;
        }

        public static IApplicationBuilder AddRegistration( this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/V1/swagger.json", "Estimador Api V1");
            });

            return app;

        }

    }
}
