using estimador.Application.Commom.Interfaces;

namespace estimador.Infraestructure.Persistence
{
    public class ApplicationDbContext : IApplicationDbContext
    {
        public ApplicationDbContext( IProductoRepository productoRepository)
        {
            ProductoRepository = productoRepository;

        }

        public IProductoRepository ProductoRepository { get; set; }

    }
}
