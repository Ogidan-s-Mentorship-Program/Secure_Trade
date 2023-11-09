using Microsoft.EntityFrameworkCore;
using SecureTrade.DataAccess.Context;
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
        private readonly MyAppContext _appContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(MyAppContext myAppContext)
        {
            _appContext = myAppContext;
            _dbSet = myAppContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return await _appContext.SaveChangesAsync() > 0;
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _appContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);
            if (entityToDelete != null)
            {
                await DeleteAsync(entityToDelete);
                return;
            }
            var typeName = typeof(T).Name;
            throw new ArgumentException($"{typeName} with Id {id} does not exist");
        }

        public async Task DeleteAsync(T entityToDelete)
        {
            _dbSet.Remove(entityToDelete);
            await _appContext.SaveChangesAsync();
        }

        //public Task DeleteAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteAsync(T entityToDelete)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<T>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<T> GetByIdAysnc(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> InsertAsync(T entityToInsert)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateAsync(T entityToUpdate)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
