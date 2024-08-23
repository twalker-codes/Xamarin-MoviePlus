﻿using System;
using MovieStreamTemplate.Resources;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class ChangePasswordViewModel: BaseViewModel
    {
        public Command SaveCommand { get; }

        private string currentPassword;
        public string CurrentPassword
        {
            get => currentPassword;
            set => SetProperty(ref currentPassword, value);
        }

        private string newPassword;
        public string NewPassword
        {
            get => newPassword;
            set => SetProperty(ref newPassword, value);
        }

        private string confirmNewPassword;
        public string ConfirmNewPassword
        {
            get => confirmNewPassword;
            set => SetProperty(ref confirmNewPassword, value);
        }

        public ChangePasswordViewModel()
        {
            Title = AppResources.ChangePassword;

            SaveCommand = new Command(OnSaveTapped);
        }

        private async void OnSaveTapped()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

