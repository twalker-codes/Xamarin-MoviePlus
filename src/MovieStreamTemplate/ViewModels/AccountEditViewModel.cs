using System;
using MovieStreamTemplate.Resources;
using MovieStreamTemplate.Services;
using System.Threading.Tasks;
using Xamarin.Forms;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.ViewModels
{
    public class AccountEditViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command SaveCommand { get; }
        public Command EditPhotoCommand { get; }

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

        private string username;
        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        private Person person;

        public AccountEditViewModel()
        {
            LoadPerson(Globals.LoggedPersonId);

            Title = AppResources.AccountDetails;

            SaveCommand = new Command(async () => await OnSaveTapped());

            EditPhotoCommand = new Command(async () => {
                await Shell.Current.DisplayAlert(AppResources.Info, AppResources.EditPhotoTapped, AppResources.OK);
            });
        }

        private async void LoadPerson(string id)
        {
            person = await service.GetPersonAsync(id);
            Photo = person.Photo;
            FullName = person.FullName;
            Username = person.Username;
            Email = person.Email;
        }

        private async Task OnSaveTapped()
        {
            person.FullName = fullName;
            person.Username = username;
            person.Email = email;

            await service.UpdatePersonAsync(person);

            await Shell.Current.GoToAsync("..");
        }
    }
}

