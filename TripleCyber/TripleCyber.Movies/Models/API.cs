namespace TripleCyber.Movies.Models
{
    public static class API
    {
        public static string BaseURL { get; set; } = "https://api.themoviedb.org/3/movie";

        public static string ApiKey { get; set; } = "bf091621962bdf5c30339e874a2a0c1a";

        public static string ImageBaseURL { get; set; } = "https://image.tmdb.org/t/p/w500";
    }
}
