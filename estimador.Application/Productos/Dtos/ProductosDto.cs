using System;
using System.Collections.Generic;
using System.Text;

namespace estimador.Application.Productos.Dtos
{
    public class ProductosDto
    {
        public int IdProducto { get; set; }
        public string nombre { get; set; }
        public double precioVenta { get; set; }
        public string Estado { get; set; }
    }
}
