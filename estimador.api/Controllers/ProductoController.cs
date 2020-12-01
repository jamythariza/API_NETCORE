using estimador.Application.Productos.Commands;
using estimador.Application.Productos.Dtos;
using estimador.Application.Productos.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace estimador.api.Controllers
{
    
    [ApiController]
    public class ProductoController : ApiController
    {
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<ProductosDto>>> Get()
        {
            return await Mediator.Send(new GetProductosQuery());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<int>> Post(CreateProductoCommand command)
        {
            return await Mediator.Send(command);

        }

    }
}
