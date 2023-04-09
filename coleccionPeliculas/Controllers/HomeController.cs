using coleccionPeliculas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using coleccionPeliculas.Services;

namespace coleccionPeliculas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicioApi _servicioApi;

        public HomeController( IServicioApi servicioApi)
        {
            _servicioApi=servicioApi;
        }

        public async Task<ActionResult<IEnumerable<Movie>>> Index(string titleFilter)
        {
            if (string.IsNullOrWhiteSpace(titleFilter))
            {
                return View();
            }
            var movies = await _servicioApi.SearchMoviesAsync(titleFilter);
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}