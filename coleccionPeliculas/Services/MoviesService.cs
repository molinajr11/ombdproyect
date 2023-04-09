using coleccionPeliculas.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using WebMovies.Models;

namespace coleccionPeliculas.Services
{
    public class MoviesService : IServicioApi
    {
        

        public MoviesService()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();   
        }

        public async Task<IEnumerable<Movie>> SearchMoviesAsync(string searchString)
        {
            var cliente = new HttpClient();
            var response = await cliente.GetAsync($"http://www.omdbapi.com/?i=tt3896198&apikey=b6f9686e&s={searchString}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<SearchResult>(json);
            return result.Search;
        }
    }
}
