using System;

namespace MovieStreamTemplate.Models
{
    public class SearchItem: Entity
    {
        public string Keyword { get; set; }

        public DateTime DateTimeGmt { get; }

        public SearchItem(string keyword)
        {
            Id = Guid.NewGuid().ToString();
            DateTimeGmt = DateTime.UtcNow;
            Keyword = keyword;
        }
    }
}

