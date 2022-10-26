using Newtonsoft.Json;

namespace TripleCyber.Movies.Models
{
    public class Result
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
        
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        public List<Movie> Favorites { get; set; }

        public bool ShowOnlyFavorites { get; set; }
    }
}
