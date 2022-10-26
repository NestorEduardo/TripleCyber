using Newtonsoft.Json;

namespace TripleCyber.Movies.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("poster_path")]
        public string Poster { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        public bool IsFavorite { get; set; }
    }
}
