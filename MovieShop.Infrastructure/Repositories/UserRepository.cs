using MovieShop.Core.Entities;
using MovieShop.Core.RepositoryInterfaces;
using MovieShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Infrastructure.Repositories
{
  public  class UserRepository : EtRepository<User>, IuserRepository
    {
        public UserRepository(MovieDBContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

    }
}
