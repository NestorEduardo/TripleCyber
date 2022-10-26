using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using TripleCyber.Movies.Models;

namespace TripleCyber.Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static HttpClient client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            Result movies = new Result();

            HttpResponseMessage response = await client.GetAsync($"{API.BaseURL}/top_rated?api_key={API.ApiKey}&language=en-US&page={page}");
            
            if (response.IsSuccessStatusCode)
            {
                movies = await response.Content.ReadAsAsync<Result>();
            }

           movies.Favorites =  HttpContext.Session.GetObjectFromJson<List<Movie>>("Favorites") ?? new List<Movie>();

            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            Movie movie = new Movie();

            HttpResponseMessage response = await client.GetAsync($"{API.BaseURL}/{id}?api_key={API.ApiKey}");

            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<Movie>();
            }

            var favorites = HttpContext.Session.GetObjectFromJson<List<Movie>>("Favorites");

            if (favorites == null)
            {
                favorites = new List<Movie>();
            }
            movie.IsFavorite = favorites.Any(f => f.Id == id);

            return View(movie);
        }

        public async Task<IActionResult> AddToFavorites(int id)
        {


            var favorites = HttpContext.Session.GetObjectFromJson<List<Movie>>("Favorites");

            if (favorites is null)
            {
                favorites = new List<Movie>();
            }
            
            Movie movie = new Movie();

            HttpResponseMessage response = await client.GetAsync($"{API.BaseURL}/{id}?api_key={API.ApiKey}");

            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<Movie>();
            }

            if (!favorites.Any(f => f.Id == id))
            {
                favorites.Add(movie);
            } else
            {
                favorites = favorites.Where(f => f.Id != id).ToList();
            }


            HttpContext.Session.SetObjectAsJson("Favorites", favorites);


            return RedirectToAction("Details", new { id = id });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}