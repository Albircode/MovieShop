using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.models.Response;

namespace MovieShop.Core.SeviceInterfaces
{
    interface ICastService
    {
        Task<CastDetailsResponseModel> GetCastDetailsWithMovies(int id);
    }
}
