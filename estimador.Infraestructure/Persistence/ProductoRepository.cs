using Microsoft.Extensions.Configuration;
using Dapper;
using estimador.Application.Commom.Interfaces;
using estimador.Domain.Entities;
using estimador.Infraestructure.Commom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace estimador.Infraestructure.Persistence
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IConfiguration _configuracion;
        private readonly string StoreProcedure_Get = "sp_producto_Get1";
        private readonly string StoreProcedure_Add = "sp_producto_add";

        public ProductoRepository( IConfiguration Configuration)
        {
            _configuracion = Configuration;

        }
        public async Task<int> Add(Producto entity)
        {
            using (var connection = ConnectionFactory.Connection(_configuracion))
            {
                connection.Open();

                var values = new
                {
                    nombre = entity.nombre,
                    referencia = entity.referencia,
                    precioVenta = entity.precioVenta,
                    codigoBarra = entity.codigoBarra,
                    categoria = entity.categoria,
                    descripcion = entity.descripcion,
                    costoUnidad = entity.costoUnidad,
                    cantidadInicial = entity.cantidadInicial,
                    cantidadMinima = entity.cantidadMinima,
                    marca = entity.marca,
                    Estado = entity.Estado,
                    color = entity.color,
                    genero = entity.genero,
                    costoEnvio = entity.costoEnvio,
                    UserName = "Administrador",
                };

                var result = await connection.QuerySingleAsync<int>(StoreProcedure_Add, values, commandType: CommandType.StoredProcedure);
                return result;
            }            

        }

        public Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Producto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producto>> GetAll()
        {
           using (var connection = ConnectionFactory.Connection(_configuracion))
            {
                connection.Open();

                var result = await connection.QueryAsync<Producto>(StoreProcedure_Get, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public Task<int> Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
