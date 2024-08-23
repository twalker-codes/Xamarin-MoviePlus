using System;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Services;

namespace MovieStreamTemplate.Helpers
{
    public static class ExtensionMethods
    {
        // enum SortBy 

        public const string UNSORTED = "Default";
        public const string NAME_AZ = "Name (A-Z)";
        public const string NAME_ZA = "Name (Z-A)";
        public const string HIGHEST_RATE = "Highest Rate";
        public const string MOST_RATED = "Most Rated";
        public const string NEW_OLD = "New to Old";

        public static string FriendlyName(this SortBy sortBy)
        {
            switch(sortBy)
            {
                case SortBy.HIGHEST_RATE: return HIGHEST_RATE;
                case SortBy.MOST_RATED: return MOST_RATED;
                case SortBy.NAME_AZ: return NAME_AZ;
                case SortBy.NAME_ZA: return NAME_ZA;
                case SortBy.NEW_OLD: return NEW_OLD;
                default: return UNSORTED;
            }
        }

        public static SortBy SortByFromFriendlyName(this string name)
        {
            switch(name)
            {
                case HIGHEST_RATE: return SortBy.HIGHEST_RATE;
                case MOST_RATED: return SortBy.MOST_RATED;
                case NAME_AZ: return SortBy.NAME_AZ;
                case NAME_ZA: return SortBy.NAME_ZA;
                case NEW_OLD: return SortBy.NEW_OLD;
                default: return SortBy.UNSORTED;
            }
        }

        // enum MovieGenre

        public const string ACTION = "Action";
        public const string ADVENTURE = "Adventure";
        public const string FANTASY = "Fantasy";
        public const string HORROR = "Horror";
        public const string MYSTERY = "Mystery";
        public const string SCIENCE_FICTION = "Science-Fiction";
        public const string THRILLER = "Thriller";
        public const string ALL = "All";

        public static string FriendlyName(this MovieGenre genre)
        {
            switch(genre)
            {
                case MovieGenre.ACTION: return ACTION;
                case MovieGenre.ADVENTURE: return ADVENTURE;
                case MovieGenre.FANTASY: return FANTASY;
                case MovieGenre.HORROR: return HORROR;
                case MovieGenre.MYSTERY: return MYSTERY;
                case MovieGenre.SCIENCE_FICTION: return SCIENCE_FICTION;
                case MovieGenre.THRILLER: return THRILLER;
                default: return ALL;
            }
        }

        public static MovieGenre MovieGenreFromFriendlyName(this string name)
        {
            switch(name)
            {
                case ACTION: return MovieGenre.ACTION;
                case ADVENTURE: return MovieGenre.ADVENTURE;
                case FANTASY: return MovieGenre.FANTASY;
                case HORROR: return MovieGenre.HORROR;
                case MYSTERY: return MovieGenre.MYSTERY;
                case SCIENCE_FICTION: return MovieGenre.SCIENCE_FICTION;
                case THRILLER: return MovieGenre.THRILLER;
                default: return MovieGenre.ALL;
            }
        }

        // enum Plan

        public const string FREE = "Free Plan";
        public const string STANDARD = "Standard Plan";
        public const string PREMIUM = "Premium Plan";

        public static string FriendlyName(this Plan plan)
        {
            switch(plan)
            {
                case Plan.STANDARD: return STANDARD;
                case Plan.PREMIUM: return PREMIUM;
                default: return FREE;
            }
        }

        public static Plan PlanFromFriendlyName(this string name)
        {
            switch(name)
            {
                case STANDARD: return Plan.STANDARD;
                case PREMIUM: return Plan.PREMIUM;
                default: return Plan.FREE;
            }
        }

        // enum DownloadStatus

        public const string NO_DOWNLOAD = "No Download";
        public const string DOWNLOADING = "Downloading";
        public const string DOWNLOADED = "Downloaded";

        public static string FriendlyName(this DownloadStatus status)
        {
            switch(status)
            {
                case DownloadStatus.NoDownload: return NO_DOWNLOAD;
                case DownloadStatus.Downloading: return DOWNLOADING;
                case DownloadStatus.Downloaded: return DOWNLOADED;
                default: return "Unknown";
            }
        }

        public static DownloadStatus DownloadStatusFromFriendlyName(this string name)
        {
            switch(name)
            {
                case DOWNLOADED: return DownloadStatus.Downloaded;
                case DOWNLOADING: return DownloadStatus.Downloading;
                default: return DownloadStatus.NoDownload;
            }
        }
    }
}

