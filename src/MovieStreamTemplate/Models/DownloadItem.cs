using System;

namespace MovieStreamTemplate.Models
{
    public class DownloadItem: Entity
    {
        public string MovieId { get; set; }

        public DateTime DateGmt { get; set; }

        public DownloadStatus Status { get; set; }

        public string MoviePoster { get; set; }

        public string MovieTitle { get; set; }

        public MovieGenre MovieGenre { get; set; }

        public int Year { get; set; }

        public int Minutes { get; set; }
    }
}

