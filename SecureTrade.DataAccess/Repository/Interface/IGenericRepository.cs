using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAysnc(Guid id);
        Task<bool> InsertAsync(T entityToInsert);
        Task UpdateAsync(T entityToUpdate);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T entityToDelete);
    }
}
