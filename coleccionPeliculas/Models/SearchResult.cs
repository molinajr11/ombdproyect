using coleccionPeliculas.Models;

namespace WebMovies.Models
{
    public class SearchResult
    {
        public IEnumerable<Movie> Search { get; set; }
       
    }
}
