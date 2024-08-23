using System;
using System.Collections.ObjectModel;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class SearchViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<SearchItem> SearchItems { get; }

        public Command LoadCommand { get; }
        public Command SearchCommand { get; }
        public Command ClearCommand { get; }
        public Command DeleteAllCommand { get; }
        public Command<SearchItem> ItemCommand { get; }

        private string keyword;
        public string Keyword
        {
            get => keyword;
            set
            {
                SetProperty(ref keyword, value);
            }
        }

        public SearchViewModel()
        {
            Title = AppResources.AppName;

            SearchItems = new ObservableCollection<SearchItem>();

            LoadCommand = new Command(LoadItems);

            SearchCommand = new Command(OnSearchTapped);

            ClearCommand = new Command(() => Keyword = string.Empty);

            DeleteAllCommand = new Command(OnDeleteAllTapped);

            ItemCommand = new Command<SearchItem>(async (item) =>
            {
                await service.DeleteSearchItemAsync(item.Id);
                Keyword = item.Keyword;
                OnSearchTapped();
            });
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async void LoadItems()
        {
            IsBusy = true;

            SearchItems.Clear();

            var searchItems = await service.GetAllSearchItems();

            foreach (var item in searchItems)
                SearchItems.Add(item);

            IsBusy = false;
        }

        async void OnSearchTapped()
        {
            await service.AddSearchItem(new SearchItem(keyword));

            await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                                          $"?{nameof(MoviesViewModel.Name)}={keyword}" +
                                          $"&{nameof(MoviesViewModel.Title)}=Results for '{keyword}'");
        }

        async void OnDeleteAllTapped()
        {
            var answer = await Shell.Current.DisplayAlert(AppResources.Question,
                            AppResources.DoYouWantToDeleteSearchHistory, AppResources.OK, AppResources.Cancel);

            if (answer)
            {
                await service.DeleteAllSearchItems();
                Keyword = string.Empty;
                IsBusy = true;
            }
        }
    }
}

