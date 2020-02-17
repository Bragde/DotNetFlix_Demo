using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFlix.Web.Models
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovieByTitle(string title);
    }
}
