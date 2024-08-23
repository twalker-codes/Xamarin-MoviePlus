using System;
using System.Collections.ObjectModel;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Helpers;
using Xamarin.Forms;
using System.Globalization;
using MovieStreamTemplate.Views;

namespace MovieStreamTemplate.ViewModels
{
    [QueryProperty(nameof(Title), nameof(Title))]
    [QueryProperty(nameof(Name), nameof(Name))]
    [QueryProperty(nameof(Genre), nameof(Genre))]
    [QueryProperty(nameof(Sort), nameof(Sort))]
    [QueryProperty(nameof(OnlyInWatchList), nameof(OnlyInWatchList))]
    [QueryProperty(nameof(OnlyNew), nameof(OnlyNew))]
    [QueryProperty(nameof(OnlyFeatured), nameof(OnlyFeatured))]
    [QueryProperty(nameof(OnlyTrending), nameof(OnlyTrending))]
    [QueryProperty(nameof(OnlyDownloaded), nameof(OnlyDownloaded))]
    public class MoviesViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<Movie> Movies { get; }

        public Command LoadCommand { get; }
        public Command SortCommand { get; }
        public Command<string> MovieTappedCommand { get; }

        private MovieGenre genre;
        public string Genre
        {
            get
            {
                return genre.FriendlyName();
            }

            set
            {
                genre = value.MovieGenreFromFriendlyName();
            }
        }

        private SortBy sort;
        public string Sort
        {
            get
            {
                return sort.FriendlyName();
            }

            set
            {
                sort = value.SortByFromFriendlyName();
            }
        }

        public string Name { get; set; }

        public bool OnlyInWatchList { get; set; }

        public bool OnlyNew { get; set; }

        public bool OnlyFeatured { get; set; }

        public bool OnlyTrending { get; set; }

        public bool OnlyDownloaded { get; set; }

        public MoviesViewModel()
        {
            Title = AppResources.Movies;
            genre = MovieGenre.ALL;
            sort = SortBy.UNSORTED;

            Movies = new ObservableCollection<Movie>();

            LoadCommand = new Command(Load);
            SortCommand = new Command(OnSortTapped);
            MovieTappedCommand = new Command<string>(async (movieId) =>
                await Shell.Current.GoToAsync($"{nameof(MovieDetailPage)}" +
                                            $"?{nameof(MovieDetailViewModel.MovieId)}={movieId}"));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async void Load()
        {
            IsBusy = true;

            Movies.Clear();

            var movies = await service.GetMoviesAsync(Globals.LoggedPersonId,
                                name: Name,
                                genre: genre,
                                sortBy: sort,
                                onlyInWatchList: OnlyInWatchList,
                                onlyNew: OnlyNew,
                                onlyFeatured: OnlyFeatured,
                                onlyTrending: OnlyTrending,
                                onlyDownloaded: OnlyDownloaded);

            foreach (var movie in movies)
                Movies.Add(movie);

            IsBusy = false;
        }

        async void OnSortTapped()
        {
            var action = await Shell.Current.DisplayActionSheet(AppResources.SortBy,
                                AppResources.Cancel, null,
                                SortBy.UNSORTED.FriendlyName(),
                                SortBy.NAME_AZ.FriendlyName(),
                                SortBy.NAME_ZA.FriendlyName(),
                                SortBy.HIGHEST_RATE.FriendlyName(),
                                SortBy.MOST_RATED.FriendlyName(),
                                SortBy.NEW_OLD.FriendlyName());

            if (action == "Cancel") return;

            sort = ExtensionMethods.SortByFromFriendlyName(action);
            IsBusy = true;
        }
    }
}

