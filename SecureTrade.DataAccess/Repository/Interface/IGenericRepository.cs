using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T entityToDelete);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<bool> InsertAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
