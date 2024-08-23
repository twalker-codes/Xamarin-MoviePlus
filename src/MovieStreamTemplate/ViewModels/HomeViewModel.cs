using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Services;
using Xamarin.Forms;
using MovieStreamTemplate.Helpers;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Views;

namespace MovieStreamTemplate.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public ObservableCollection<string> Genres { get; }
        public ObservableCollection<Movie> FeaturedMovies { get; }
        public ObservableCollection<Movie> TrendingMovies { get; }
        public ObservableCollection<Movie> NewMovies { get; }
        public ObservableCollection<Movie> TopRatingMovies { get; }

        public Command LoadPageCommand { get; }
        public Command FeaturedMoviesCommand { get; }
        public Command TrendingMoviesCommand { get; }
        public Command NewMoviesCommand { get; }
        public Command TopRatingMoviesCommand { get; }
        public Command<string> GenreCommand { get; }

        public HomeViewModel()
        {
            Title = AppResources.AppName;

            Genres = new ObservableCollection<string>();
            FeaturedMovies = new ObservableCollection<Movie>();
            TrendingMovies = new ObservableCollection<Movie>();
            NewMovies = new ObservableCollection<Movie>();
            TopRatingMovies = new ObservableCollection<Movie>();

            LoadPageCommand = new Command(LoadPage);

            FeaturedMoviesCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                                              $"?{nameof(MoviesViewModel.OnlyFeatured)}=True" +
                                              $"&{nameof(MoviesViewModel.Title)}={AppResources.FeaturedMovies}");
            });

            TrendingMoviesCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                                              $"?{nameof(MoviesViewModel.OnlyTrending)}=True" +
                                              $"&{nameof(MoviesViewModel.Title)}={AppResources.TrendingMovies}");
            });

            NewMoviesCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                                              $"?{nameof(MoviesViewModel.OnlyNew)}=True" +
                                              $"&{nameof(MoviesViewModel.Title)}={AppResources.NewMovies}");
            });

            TopRatingMoviesCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                                              $"?{nameof(MoviesViewModel.Sort)}={SortBy.HIGHEST_RATE.FriendlyName()}" +
                                              $"&{nameof(MoviesViewModel.Title)}={AppResources.TopRatingMovies}");
            });

            GenreCommand = new Command<string>(async (genre) =>
                await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                              $"?{nameof(MoviesViewModel.Genre)}={genre}" +
                              $"&{nameof(MoviesViewModel.Title)}={genre}"));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async void LoadPage()
        {
            IsBusy = true;

            // Movie Genres

            Genres.Clear();

            foreach (var genre in (MovieGenre[])Enum.GetValues(typeof(MovieGenre)))
                Genres.Add(genre.FriendlyName());

            // Featured Movies

            FeaturedMovies.Clear();

            var featuredMovies = await service.GetMoviesAsync(Globals.LoggedPersonId, onlyFeatured: true);

            foreach (var movie in featuredMovies.Take(6))
                FeaturedMovies.Add(movie);

            // Trending Movies

            TrendingMovies.Clear();

            var trendingMovies = await service.GetMoviesAsync(Globals.LoggedPersonId, onlyTrending: true);

            foreach (var movie in trendingMovies.Take(6))
                TrendingMovies.Add(movie);

            // New Movies

            NewMovies.Clear();

            var newMovies = await service.GetMoviesAsync(Globals.LoggedPersonId, onlyNew: true);

            foreach (var movie in newMovies.Take(6))
                NewMovies.Add(movie);

            // Top Rating Movies

            TopRatingMovies.Clear();

            var topRatingMovies = await service.GetMoviesAsync(Globals.LoggedPersonId, sortBy: SortBy.HIGHEST_RATE);

            foreach (var movie in topRatingMovies.Take(6))
                TopRatingMovies.Add(movie);

            IsBusy = false;
        }

    }
}

