using System.Collections.Generic;
using System.Threading.Tasks;

namespace estimador.Application.Commom.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int Id);
        Task<IEnumerable<T>> GetAll();
        Task<int> Add(T entity);
        Task<int> Delete(int Id);
        Task<int> Update(T entity);

    }
}
