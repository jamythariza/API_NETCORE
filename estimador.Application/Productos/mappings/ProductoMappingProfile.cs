using AutoMapper;
using estimador.Application.Productos.Commands;
using estimador.Application.Productos.Dtos;
using estimador.Domain.Entities;

namespace estimador.Application.Productos.mappings
{
   public class ProductoMappingProfile : Profile
    {
        public ProductoMappingProfile()
        {
            CreateMap<Producto, ProductosDto>();
            CreateMap<CreateProductoCommand, Producto>();
        }
    }
}
