using System;

namespace MovieStreamTemplate.Models
{
    /// <summary>
    /// Type represent for item of the watchlist 
    /// </summary>
    public class WatchlistItem: Entity
    {
        /// <summary>
        /// The id of the associated person
        /// </summary>
        public string PersonId { get; set; }

        /// <summary>
        /// The id of the associated movie
        /// </summary>
        public string MovieId { get; set; }
    }
}

