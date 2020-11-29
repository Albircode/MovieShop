using MovieShop.Core.Entities;
using MovieShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Core.RepositoryInterfaces
{
   public interface IuserRepository : IAsyncRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
