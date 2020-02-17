using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFlix.Web.Models
{
    public class InMemoryMovieRepository : IMovieRepository
    {
        List<Movie> movies;
        public InMemoryMovieRepository()
        {
            // Create mockup data when class is instanceiated
            movies = new List<Movie>
                {
                    new Movie{Title="Terminator"},
                    new Movie{Title="Ghostbusters"},
                    new Movie{Title="Heat"}
                };
        }

        public IEnumerable<Movie> GetMovieByTitle(string title = null)
        {
            return movies
                .Where(m => string.IsNullOrEmpty(title) || m.Title.StartsWith(title))
                .OrderBy(m => m.Title)
                .Select(m => m);
        }
    }
}
