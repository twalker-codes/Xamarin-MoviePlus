using System;

namespace MovieStreamTemplate.Models
{
    /// <summary>
    /// Type represent for review entity
    /// </summary>
    public class Review: Entity
    {
        /// <summary>
        /// The id of the associated movie
        /// </summary>
        public string MovieId { get; set; }

        /// <summary>
        /// The id of the associated person
        /// </summary>
        public string PersonId { get; set; }

        /// <summary>
        /// Count of the given stars
        /// </summary>
        public byte Star { get; set; }

        /// <summary>
        /// Date of the review
        /// </summary>
        public DateTime DateGmt { get; set; }

        /// <summary>
        /// Person's review
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Name of the author
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Photo of the author
        /// </summary>
        public string AuthorPhoto { get; set; }

        public int ThumbUp { get; set; }

        public int ThumbDown { get; set; }
    }
}

