using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<int?> Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetList();

    }
}
