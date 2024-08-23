using System;

namespace MovieStreamTemplate.Models
{
    /// <summary>
    /// Type represent for movie entity
    /// </summary>
    public class Movie: Entity
    {
        public string Poster { get; set; }

        /// <summary>
        /// Name of the movie
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year of the release date 
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Duration in minute
        /// </summary>
        public int Minutes { get; set; }

        /// <summary>
        /// Average rating of the movie
        /// </summary>
        public float AverageRating { get; set; }

        /// <summary>
        /// Number of the reviews
        /// </summary>
        public float RatingCount { get; set; }

        /// <summary>
        /// True if it is a movie that in the watchlist of the logged customer
        /// </summary>
        public bool IsInWatchlist { get; set; }

        /// <summary>
        /// True, if movie is featured
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// True, if movie is new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// True, if movie is trending
        /// </summary>
        public bool IsTrending { get; set; }

        /// <summary>
        /// Genre of the movie
        /// </summary>
        public MovieGenre Genre { get; set; }

        /// <summary>
        /// Text about movie
        /// </summary>
        public string Description { get; set; }

        public DownloadStatus DownloadStatus { get; set; }

        public string DirectorId { get; set; }

        public Person Director { get; set; }

        public string[] ActorIds { get; set; }

        public Person[] Actors { get; set; }


    }
}

