using System;
using System.Collections.Generic;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.DataStores.MockDataStore
{
    public class WatchlistItemDataStore: BaseDataStore<WatchlistItem>, IWatchlistItemDataStore
    {
        protected override IList<WatchlistItem> items { get; }

        public WatchlistItemDataStore()
        {
            items = new List<WatchlistItem>
            {
                new WatchlistItem
                {
                     Id = "001",
                     PersonId = "032",
                     MovieId = "006",
                },

                new WatchlistItem
                {
                    Id = "002",
                    PersonId = "032",
                    MovieId = "019",
                },

                new WatchlistItem
                {
                    Id = "003",
                    PersonId = "032",
                    MovieId = "025"
                },

                new WatchlistItem
                {
                    Id = "004",
                    PersonId = "032",
                    MovieId = "036"
                },

                new WatchlistItem
                {
                    Id = "005",
                    PersonId = "032",
                    MovieId = "038"
                },

                new WatchlistItem
                {
                    Id = "006",
                    PersonId = "032",
                    MovieId = "044",
                },

                new WatchlistItem
                {
                    Id = "007",
                    PersonId = "032",
                    MovieId = "047"
                },

                new WatchlistItem
                {
                    Id = "008",
                    PersonId = "032",
                    MovieId = "050"
                },

            };
        }

    }
}

