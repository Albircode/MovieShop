using Microsoft.EntityFrameworkCore;
using MovieShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Infrastructure.Repositories
{
    public class EtRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly MovieDBContext _DBContext;
        public EtRepository(MovieDBContext dbContext)
        {
            _DBContext = dbContext;
        }
        
        public async Task<T> AddAsync(T entity)
        {
            await _DBContext.Set<T>().AddAsync(entity);
            await _DBContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _DBContext.Set<T>().Remove(entity);
            await _DBContext.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            var entity = await _DBContext.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter=null)
        {
            if (filter != null)
            {
                return await _DBContext.Set<T>().Where(filter).CountAsync();
            }
            return await _DBContext.Set<T>().CountAsync();
        }

        public async Task<bool> GetExistAsync(Expression<Func<T, bool>> filter=null)
        {
            if (filter != null && await _DBContext.Set<T>().Where(filter).AnyAsync())
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _DBContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            return await _DBContext.Set<T>().Where(filter).ToListAsync();

        }

        public async Task<T> UpdateAsync(T entity)
        {
            _DBContext.Entry(entity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
            return entity;
        }
    }
}
