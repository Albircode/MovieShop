using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.models.Request;
using MovieShop.Core.SeviceInterfaces;
using System.Threading.Tasks;

namespace MovieShop.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MovieByGenre(int genreId)
        {
            return View();
        }
        public IActionResult Detail(int movieId)
        {
            return View();
        }
        [HttpGet]

        [Authorize]

        public async Task<IActionResult> Create()

        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(MovieCreateRequest model)
        {
            await _movieService.CreateMovie(model);
            return View();
        }
    }
}
