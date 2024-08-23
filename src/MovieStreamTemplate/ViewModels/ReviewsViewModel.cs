using System;
using System.Collections.ObjectModel;
using MovieStreamTemplate.Helpers;
using System.Net.NetworkInformation;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    [QueryProperty(nameof(MovieId), nameof(MovieId))]
    public class ReviewsViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<Review> Reviews { get; }

        public Command LoadCommand { get; }
        public Command AddCommand { get; }

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

        public ReviewsViewModel()
        {
            Title = AppResources.Reviews;

            Reviews = new ObservableCollection<Review>();
            LoadCommand = new Command(LoadReviews);
            AddCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(NewReviewPage)}" +
                                            $"?{nameof(NewReviewViewModel.MovieId)}={movieId}"));
        }

        public void OnAppearing()
        {
            LoadMovie();
            IsBusy = true;
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
        }

        async void LoadReviews()
        {
            IsBusy = true;

            Reviews.Clear();
            var reviews = await service.GetReviewsAsync(movieId);

            foreach (var review in reviews)
                Reviews.Add(review);

            IsBusy = false;
        }
    }
}

