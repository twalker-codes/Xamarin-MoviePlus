using System;
using MovieStreamTemplate.Helpers;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    [QueryProperty(nameof(MovieId), nameof(MovieId))]
    public class NewReviewViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command StarCommand { get; }
        public Command SubmitCommand { get; }

        private string movieId;
        public string MovieId
        {
            get => movieId;
            set
            {
                movieId = value;
                LoadMovie();
            }
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

        private float starCount;
        public float StarCount
        {
            get => starCount;
            set => SetProperty(ref starCount, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public NewReviewViewModel()
        {
            Title = AppResources.NewReview;

            StarCommand = new Command<String>(OnStarTapped);
            SubmitCommand = new Command(OnSubmitTapped);

            StarCount = 5;
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

        private void OnStarTapped(String star)
        {
            StarCount = int.Parse(star);
        }

        private async void OnSubmitTapped()
        {
            Review review = new Review
            {
                Id = Guid.NewGuid().ToString(),
                MovieId = movieId,
                PersonId = Globals.LoggedPersonId,
                DateGmt = DateTime.UtcNow,
                Star = (byte)starCount,
                Text = text,
            };

            await service.AddReviewAsync(review);
            await Shell.Current.GoToAsync("..");
        }

    }
}

