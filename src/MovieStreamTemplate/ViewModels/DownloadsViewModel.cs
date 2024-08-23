using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class DownloadsViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<DownloadItem> Movies { get; }

        public Command LoadCommand { get; }
        public Command DeleteAllCommand { get; }
        public Command<DownloadItem> MovieTappedCommand { get; }
        public Command<DownloadItem> PlayCommand { get; }
        public Command<DownloadItem> DeleteCommand { get; }

        public DownloadsViewModel()
        {
            Title = AppResources.AppName;

            Movies = new ObservableCollection<DownloadItem>();

            LoadCommand = new Command(LoadMovies);
            DeleteAllCommand = new Command(OnDeleteAllTapped);
            MovieTappedCommand = new Command<DownloadItem>(OnMovieTapped);
            PlayCommand = new Command<DownloadItem>(OnPlayTapped);
            DeleteCommand = new Command<DownloadItem>(OnDeleteTapped);
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async void LoadMovies()
        {
            IsBusy = true;

            Movies.Clear();

            var items = await service.GetDownloadItemsAsync();

            foreach (var item in items)
                Movies.Add(item);

            IsBusy = false;
        }

        async void OnDeleteAllTapped()
        {
            var answer = await Shell.Current.DisplayAlert(AppResources.Question,
                            AppResources.DoYouWantToDeleteAllDownloadedMovies, AppResources.OK, AppResources.Cancel);

            if (answer)
            {
                await service.RemoveAllDownloadItemAsync();
                IsBusy = true;
            }
        }

        async void OnMovieTapped(DownloadItem item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(MovieDetailPage)}" +
                                        $"?{nameof(MovieDetailViewModel.MovieId)}={item.MovieId}");
        }

        async void OnPlayTapped(DownloadItem item)
        {
            if (item == null) return;

            await Shell.Current.DisplayAlert(item.MovieTitle, AppResources.PlayTapped, AppResources.Close);
        }

        async void OnDeleteTapped(DownloadItem item)
        {
            if (item == null) return;

            var answer = await Shell.Current.DisplayAlert(AppResources.Question,
                            AppResources.DoYouWantToDeleteAllDownloadedMovies, AppResources.OK, AppResources.Cancel);

            if (answer)
            {
                await service.RemoveDownloadItemAsync(item.MovieId);
                Movies.Remove(item);
            }
        }
    }
}

