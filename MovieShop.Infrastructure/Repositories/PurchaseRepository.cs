using MovieShop.Core.Entities;
using MovieShop.Core.RepositoryInterfaces;
using MovieShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Infrastructure.Repositories
{
   public class PurchaseRepository : EtRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(MovieDBContext dbContext) : base(dbContext)
        {

        }
        public Task<IEnumerable<Purchase>> GetAllPurchases(int pageSize = 30, int pageIndex = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Purchase>> GetAllPurchasesByMovie(int movieId, int pageSize = 30, int pageIndex = 0)
        {
            throw new NotImplementedException();
        }
    }
}
