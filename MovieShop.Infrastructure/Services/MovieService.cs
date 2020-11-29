using MovieShop.Core.Entities;
using MovieShop.Core.models;
using MovieShop.Core.models.Response;
using MovieShop.Core.RepositoryInterfaces;
using MovieShop.Core.SeviceInterfaces;
using MovieShop.Infrastructure.Data;
using MovieShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Infrastructure.Services
{
   public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;
        //DI is pattern that enables us to write loosely couple code 
        public MovieService(IMovieRepository repository)
        {
            // _repository = new MovieRepository(new MovieDBContext(null));
            _repository = repository;
        }

        public Task<MovieDetailsResponseModel> CreateMovie(MovieCreateRequest movieCreateRequest)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultSet<MovieResponseModel>> GetAllMoviePurchasesByPagination(int pageSize = 20, int page = 0)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedList<MovieResponseModel>> GetAllPurchasesByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MovieResponseModel>> GetTopRevenueMovies()
        {
            var movies = await _repository.GetHighestRevenueMovies();
            // Map our Movie Entity to MovieResponseModel
            var movieResponseModel = new List<MovieResponseModel>();
            foreach (var movie in movies)
            {
                movieResponseModel.Add(new MovieResponseModel
                {
                    Id = movie.Id,
                    PosterUrl = movie.PosterUrl,
                    ReleaseDate = movie.ReleaseDate.Value,
                    Title = movie.Title
                });
            }

            return movieResponseModel;
        }
    

        public Task<MovieDetailsResponseModel> GetMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieResponseModel>> GetMoviesByGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultSet<MovieResponseModel>> GetMoviesByPagination(int pageSize = 20, int page = 0, string title = "")
        {
            throw new NotImplementedException();
        }

        public Task<int> GetMoviesCount(string title = "")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewMovieResponseModel>> GetReviewsForMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieResponseModel>> GetTopRatedMovies()
        {
            throw new NotImplementedException();
        }

        public Task<MovieDetailsResponseModel> UpdateMovie(MovieCreateRequest movieCreateRequest)
        {
            throw new NotImplementedException();
        }

        Task<PagedResultSet<MovieResponseModel>> IMovieService.GetMoviesByPagination(int pageSize, int page, string title)
        {
            throw new NotImplementedException();
        }

        Task<PagedResultSet<MovieResponseModel>> IMovieService.GetAllMoviePurchasesByPagination(int pageSize, int page)
        {
            throw new NotImplementedException();
        }

        Task<PaginatedList<MovieResponseModel>> IMovieService.GetAllPurchasesByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        Task<MovieDetailsResponseModel> IMovieService.GetMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ReviewMovieResponseModel>> IMovieService.GetReviewsForMovie(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<MovieResponseModel>> IMovieService.GetTopRatedMovies()
        {
            throw new NotImplementedException();
        }


        Task<IEnumerable<MovieResponseModel>> IMovieService.GetMoviesByGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        //public Task<MovieDetailsResponseModel> CreateMovie(MovieCreateRequest movieCreateRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<MovieDetailsResponseModel> UpdateMovie(MovieCreateRequest movieCreateRequest)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
