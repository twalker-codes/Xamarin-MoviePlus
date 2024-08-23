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
    public class MyProfileViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<ProfileViewModel> Profiles { get; }

        public Command UpdatePlanCommand { get; }
        public Command<ProfileViewModel> ProfileCommand { get; }
        public Command EditProfileCommand { get; }
        public Command AddProfileCommand { get; }
        public Command WatchlistCommand { get; }
        public Command AccountDetailsCommand { get; }
        public Command ChangePasswordCommand { get; }
        public Command SettingCommand { get; }
        public Command HelpCommand { get; }
        public Command LogOutCommand { get; }

        private string photo;
        public string Photo
        {
            get => photo;
            set => SetProperty(ref photo, value);
        }

        private string fullName;
        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
        }

        private string plan;
        public string Plan
        {
            get => plan;
            set => SetProperty(ref plan, value);
        }

        private string selectedProfileId = "001";

        public MyProfileViewModel()
        {
            Title = AppResources.AppName;

            Profiles = new ObservableCollection<ProfileViewModel>();

            UpdatePlanCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(CheckoutPlanPage)}"));

            ProfileCommand = new Command<ProfileViewModel>(OnProfileTapped);

            EditProfileCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(ProfileEditPage)}" +
                                              $"?{nameof(ProfileEditViewModel.ProfileId)}={selectedProfileId}"));

            AddProfileCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(ProfileEditPage)}"));

            WatchlistCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(MoviesPage)}" +
                                              $"?{nameof(MoviesViewModel.OnlyInWatchList)}=True" +
                                              $"&{nameof(MoviesViewModel.Title)}={AppResources.Watchlist}"));

            AccountDetailsCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(AccountEditPage)}"));

            ChangePasswordCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(ChangePasswordPage)}"));

            SettingCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(SettingPage)}"));

            HelpCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(HelpPage)}"));

            LogOutCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(LoginPage)}"));

        }

        public async void OnAppearing()
        {
            var person = service.GetPersonAsync(Globals.LoggedPersonId).Result;

            Photo = person.Photo;
            FullName = person.FullName;
            Plan = person.Plan.FriendlyName();

            Profiles.Clear();

            var profiles = await service.GetProfilesAsync(Globals.LoggedPersonId);

            foreach (var profile in profiles)
                Profiles.Add(new ProfileViewModel(profile, profile.Id == selectedProfileId));
        }


        void OnProfileTapped(ProfileViewModel profile)
        {
            if (profile == null) return;

            foreach (var p in Profiles)
                p.IsSelected = p.Id == profile.Id;

            selectedProfileId = profile.Id;
        }
    }
}

