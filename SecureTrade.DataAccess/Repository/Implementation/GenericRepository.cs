using SecureTrade.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public GenericRepository()
        {
            
        }


        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAysnc(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(T entityToInsert)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
