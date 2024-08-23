using System;
using System.Collections.ObjectModel;
using MovieStreamTemplate.Helpers;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    [QueryProperty(nameof(MovieId), nameof(MovieId))]
    public class MovieDetailViewModel : BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public ObservableCollection<Person> Actors { get; }
        public ObservableCollection<Review> LastReviews { get; }

        public Command PlayCommand { get; }
        public Command DownloadCommand { get; }
        public Command WatchlistCommand { get; }
        public Command ShowReviewsCommand { get; }

        private string movieId;
        public string MovieId
        {
            get => movieId;
            set => movieId = value;
        }

        private string poster;
        public string Poster
        {
            get => poster;
            set => SetProperty(ref poster, value);
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private float averageRating;
        public float AverageRating
        {
            get => averageRating;
            set => SetProperty(ref averageRating, value);
        }

        private float ratingCount;
        public float RatingCount
        {
            get => ratingCount;
            set => SetProperty(ref ratingCount, value);
        }

        private string genre;
        public string Genre
        {
            get => genre;
            set => SetProperty(ref genre, value);
        }

        private int year;
        public int Year
        {
            get => year;
            set => SetProperty(ref year, value);
        }

        private string duration;
        public string Duration
        {
            get => duration;
            set => SetProperty(ref duration, value);
        }

        private bool isInWatchlist;
        public bool IsInWatchlist
        {
            get => isInWatchlist;
            set
            {
                SetProperty(ref isInWatchlist, value);
                OnPropertyChanged(nameof(WatchlistLabelText));
                OnPropertyChanged(nameof(WatchlistButtonCaption));
            }
        }

        private string description;
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        private string directorPhoto;
        public string DirectorPhoto
        {
            get => directorPhoto;
            set => SetProperty(ref directorPhoto, value);
        }

        private string directorName;
        public string DirectorName
        {
            get => directorName;
            set => SetProperty(ref directorName, value);
        }

        private DownloadStatus status;
        public DownloadStatus Status
        {
            get => status;
            set
            {
                SetProperty(ref status, value);
                OnPropertyChanged(nameof(DownloadLabelText));
                OnPropertyChanged(nameof(DownloadLabelIsVisible));
                OnPropertyChanged(nameof(DownloadButtonCaption));
            }
        }

        public string DownloadLabelText
        {
            get
            {
                switch (Status)
                {
                    case DownloadStatus.NoDownload: return string.Empty;
                    case DownloadStatus.Downloading: return AppResources.Downloading;
                    case DownloadStatus.Downloaded: return AppResources.Downloaded;
                    default: return "Unknown";
                }
            }
        }

        public bool DownloadLabelIsVisible
        {
            get => Status == DownloadStatus.NoDownload ? false : true;
        }

        public string DownloadButtonCaption
        {
            get
            {
                switch(Status)
                {
                    case DownloadStatus.NoDownload: return AppResources.Download;
                    case DownloadStatus.Downloading: return AppResources.CancelDownload;
                    case DownloadStatus.Downloaded: return AppResources.DeleteDownload;
                    default: return "Unknown";
                }
            }
        }

        public string WatchlistLabelText
        {
            get => isInWatchlist ? AppResources.InWatchlist : string.Empty;
        }

        public string WatchlistButtonCaption
        {
            get => isInWatchlist ? AppResources.RemoveFromWatchlist : AppResources.AddToWatchlist;
        }

        public MovieDetailViewModel()
        {
            Actors = new ObservableCollection<Person>();
            LastReviews = new ObservableCollection<Review>();

            PlayCommand = new Command(async () =>
                await Shell.Current.DisplayAlert(Name, AppResources.PlayTapped, AppResources.Close));

            DownloadCommand = new Command(OnDownloadTapped);

            WatchlistCommand = new Command(OnWatchlistTapped);

            ShowReviewsCommand = new Command(async () => 
                await Shell.Current.GoToAsync($"{nameof(ReviewsPage)}" +
                                            $"?{nameof(ReviewsViewModel.MovieId)}={movieId}"));
        }

        public void OnAppearing()
        {
            LoadMovie();
            LoadReviews();
        }

        async void LoadMovie()
        {
            var movie = await service.GetMovieAsync(movieId);

            Poster = movie.Poster;
            Name = movie.Name;
            AverageRating = movie.AverageRating;
            RatingCount = movie.RatingCount;
            Genre = movie.Genre.FriendlyName();
            Year = movie.Year;
            Duration = $"{movie.Minutes} {AppResources.Mins}";
            IsInWatchlist = movie.IsInWatchlist;
            Description = movie.Description;
            DirectorPhoto = movie.Director.Photo;
            DirectorName = movie.Director.FullName;
            Status = movie.DownloadStatus;
        }

        async void LoadReviews()
        {
            LastReviews.Clear();

            var reviews = await service.GetReviewsAsync(movieId);

            foreach (var review in reviews)
                LastReviews.Add(review);
        }

        async void OnDownloadTapped()
        {
            switch(Status)
            {
                case DownloadStatus.NoDownload:
                    await service.AddDownloadItemAsync(movieId);
                    Status = DownloadStatus.Downloading;
                    break;
                case DownloadStatus.Downloading:
                    await service.RemoveDownloadItemAsync(movieId);
                    Status = DownloadStatus.NoDownload;
                    break;
                case DownloadStatus.Downloaded:
                    await service.RemoveDownloadItemAsync(movieId);
                    Status = DownloadStatus.NoDownload;
                    break;
            }
        }

        async void OnWatchlistTapped()
        {
            if (IsInWatchlist)
            {
                await service.RemoveWatchlistItemAsync(Globals.LoggedPersonId, movieId);
                IsInWatchlist = false;
            }
            else
            {
                await service.AddWatchlistItemAsync(Globals.LoggedPersonId, movieId);
                IsInWatchlist = true;
            }

        }
    }
}

