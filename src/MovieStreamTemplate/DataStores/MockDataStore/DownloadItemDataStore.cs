using System;
using System.Collections.Generic;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.DataStores.MockDataStore
{
    public class DownloadItemDataStore: BaseDataStore<DownloadItem>, IDownloadItemDataStore
    {
        protected override IList<DownloadItem> items { get; }

        public DownloadItemDataStore()
        {
            items = new List<DownloadItem>
            {
                new DownloadItem
                {
                    Id = "001",
                    MovieId = "006",
                    DateGmt = new DateTime (2022, 1, 8),
                    Status = DownloadStatus.Downloaded
                },

                new DownloadItem
                {
                    Id = "002",
                    MovieId = "007",
                    DateGmt = new DateTime (2022, 1, 8),
                    Status = DownloadStatus.Downloaded
                },

                new DownloadItem
                {
                    Id = "003",
                    MovieId = "026",
                    DateGmt = new DateTime(2022, 2, 11),
                    Status = DownloadStatus.Downloaded
                },

                new DownloadItem
                {
                    Id = "004",
                    MovieId = "033",
                    DateGmt = new DateTime(2022, 3, 30),
                    Status = DownloadStatus.Downloaded
                },

                new DownloadItem
                {
                    Id = "005",
                    MovieId = "049",
                    DateGmt = new DateTime(2022, 4, 15),
                    Status = DownloadStatus.Downloaded
                },

                new DownloadItem
                {
                    Id = "006",
                    MovieId = "051",
                    DateGmt = new DateTime(2022, 5, 3),
                    Status = DownloadStatus.Downloaded
                },

                new DownloadItem
                {
                    Id = "007",
                    MovieId = "053",
                    DateGmt = new DateTime(2022, 6, 11),
                    Status = DownloadStatus.Downloaded
                }
            };
        }

    }
}

