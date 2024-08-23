using System;

namespace MovieStreamTemplate.Models
{
    /// <summary>
    /// Type represent for person entity
    /// </summary>
    public class Person: Entity
    {
        /// <summary>
        /// Photo for the person
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// First and last name of the person
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Username for the person
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The email address for the person
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Birthday of the person
        /// </summary>
        public DateTime Birth { get; set; }

        /// <summary>
        /// About of the person
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Rewards of the person
        /// </summary>
        public string Rewards { get; set; }

        /// <summary>
        /// Account type (free, standard, premium)
        /// </summary>
        public Plan Plan { get; set; }
    }
}

