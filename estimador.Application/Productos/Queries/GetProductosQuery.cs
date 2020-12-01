using AutoMapper;
using estimador.Application.Commom.Interfaces;
using estimador.Application.Productos.Dtos;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace estimador.Application.Productos.Queries
{
    public class GetProductosQuery : IRequest<List<ProductosDto>>
    {
    }

    public class GetProductoHandle : IRequestHandler<GetProductosQuery, List<ProductosDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductoHandle(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<List<ProductosDto>> Handle(GetProductosQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.ProductoRepository.GetAll();
            return _mapper.Map<List<ProductosDto>>(result.ToList());

        }
    }
}
