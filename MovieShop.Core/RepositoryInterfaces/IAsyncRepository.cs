using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Infrastructure.Repositories
{
  public  interface IAsyncRepository<T> where T: class
    {
        //crud operation, which are common across all the repository
        //get an Entity by Id=>MovieId=>Movie
       Task <T> GetByIdAsync(int id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<IEnumerable<T>> ListAsync(Expression<Func<T,bool>>filter);
        Task<int> GetCountAsync(Expression<Func<T, bool>> filter=null);
        Task<bool> GetExistAsync(Expression<Func<T, bool>> filter=null);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);




    }
}
