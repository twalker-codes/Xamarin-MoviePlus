﻿using System;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class ResetPasswordViewModel: BaseViewModel
    {
        public Command SubmitCommand { get; }

        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public ResetPasswordViewModel()
        {
            SubmitCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        }
    }
}

