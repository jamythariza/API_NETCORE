using AutoMapper;
using estimador.Application.Commom.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace estimador.Application.Productos.Commands
{
    public class CreateProductoCommand : IRequest<int>
    {
        public string nombre { get; set; }
        public string referencia { get; set; }
        public double precioVenta { get; set; }
        public string codigoBarra { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public double costoUnidad { get; set; }
        public int cantidadInicial { get; set; }
        public int cantidadMinima { get; set; }
        public string marca { get; set; }
        public string Estado { get; set; }
        public string color { get; set; }
        public string genero { get; set; }
        public double costoEnvio { get; set; }
        public string UserName { get; set; }
    }

    public class CreateProductoHandler : IRequestHandler<CreateProductoCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public IMapper _mapper { get; }

        public CreateProductoHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
        {
            var producto = _mapper.Map<estimador.Domain.Entities.Producto>(request);

            var result = await _context.ProductoRepository.Add(producto);
            return result;
        }

    }
   
}
