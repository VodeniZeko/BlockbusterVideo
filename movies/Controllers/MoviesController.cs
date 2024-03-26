using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using movies.Models;
using movies.ViewModels;

namespace movies.Controllers
{
    public class MoviesController : Controller
    {
        //movies
        public IActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies() => new List<Movie>
            {
                new Movie{Id=1, Name= "John Wick" },
                new Movie {Id=2, Name= "American beauty" }
            };



        //GET movies/random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!!!" };
            var customers = new List<Customer>
            {
                new Customer{ Name= "Customer 1" },
                new Customer { Name= "Customer 2" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
        }

    }
}
