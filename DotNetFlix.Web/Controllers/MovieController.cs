using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetFlix.Web.Models;
using DotNetFlix.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetFlix.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public ViewResult List(string title)
        {
            // Get list of movies
            IEnumerable<Movie> movies = movieRepository.GetMovieByTitle(title);

            // Return view model
            var vm = new MovieListViewModel
            {
                Movies = movies
            };
            return View(vm);
        }
    }
}
