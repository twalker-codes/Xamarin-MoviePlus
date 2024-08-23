using System;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    [QueryProperty(nameof(ProfileId), nameof(ProfileId))]
    public class ProfileEditViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command EditImageCommand { get; }
        public Command SaveCommand { get; }
        public Command DeleteCommand { get; }

        private string profileId;
        public string ProfileId
        {
            get => profileId;
            set
            {
                profileId = value;
                LoadProfile();
            }
        }

        private string image;
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public ProfileEditViewModel()
        {
            Title = AppResources.ProfileDetails;
            Image = "profile8";

            EditImageCommand = new Command(async () =>
                await Shell.Current.DisplayAlert(AppResources.Info, AppResources.EditPhotoTapped, AppResources.Close));

            SaveCommand = new Command(SaveProfile);

            DeleteCommand = new Command(DeleteProfile);
        }

        async void LoadProfile()
        {
            var profile = await service.GetProfileAsync(profileId);
            Image = profile.Image;
            Name = profile.Name;
        }

        async void SaveProfile()
        {
            if (string.IsNullOrEmpty(Name))
            {
                await Shell.Current.DisplayAlert(AppResources.Info, AppResources.NameRequired, AppResources.OK);
                return;
            }

            var profile = new Profile
            {
                Id = profileId ?? Guid.NewGuid().ToString(),
                Image = image,
                PersonId = "032",
                Name = name
            };

            if (profileId != null)
                await service.UpdateProfileAsync(profile);
            else
                await service.AddProfileAsync(profile);

            await Shell.Current.GoToAsync("..");

        }

        async void DeleteProfile()
        {
            if (profileId == "001")
            {
                await Shell.Current.DisplayAlert(AppResources.Info, AppResources.PrimaryProfileCantDelete, AppResources.Close);
                return;
            }

            var answer = await Shell.Current.DisplayAlert(AppResources.Question,
                            AppResources.DoYouWantToDelete, AppResources.OK, AppResources.Cancel);

            if (answer == true)
            {
                await service.DeleteProfileAsync(profileId);
                await Shell.Current.GoToAsync("..");
            }
        }

    }
}

