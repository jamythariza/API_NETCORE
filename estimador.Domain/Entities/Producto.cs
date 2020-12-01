using estimador.Domain.Commom;

namespace estimador.Domain.Entities
{
    public class Producto : AuditableEntity
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
}
