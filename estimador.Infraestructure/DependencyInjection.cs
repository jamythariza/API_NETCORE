using estimador.Application.Commom.Interfaces;
using estimador.Infraestructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace estimador.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection servicios)
        {
            servicios.AddTransient<IApplicationDbContext, ApplicationDbContext>();
            servicios.AddTransient<IProductoRepository, ProductoRepository>();

            return servicios;
        }
    }
}
