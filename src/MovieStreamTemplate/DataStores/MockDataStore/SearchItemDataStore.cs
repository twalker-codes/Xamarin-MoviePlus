using System;
using System.Collections.Generic;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.DataStores.MockDataStore
{
    public class SearchItemDataStore: BaseDataStore<SearchItem>, ISearchItemDataStore
    {
        protected override IList<SearchItem> items { get; }

        public SearchItemDataStore()
        {
            items = new List<SearchItem>();
        }
    }
}

