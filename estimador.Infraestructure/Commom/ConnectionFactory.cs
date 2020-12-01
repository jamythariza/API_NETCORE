using  Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace estimador.Infraestructure.Commom
{
    public class ConnectionFactory
    {
        public static SqlConnection Connection(IConfiguration configuration)
        {
            return new SqlConnection(configuration.GetConnectionString("AppProductos"));

        }
    }
}
