using coleccionPeliculas.Models;

namespace coleccionPeliculas.Services
{
    public interface IServicioApi
    {
        Task<IEnumerable<Movie>> SearchMoviesAsync(string searchString);
    }
}
