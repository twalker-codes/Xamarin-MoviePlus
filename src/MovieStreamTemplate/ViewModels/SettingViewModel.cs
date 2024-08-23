using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class SettingViewModel: BaseViewModel
    {
        public Command TermsCommand { get; }

        public SettingViewModel()
        {
            TermsCommand = new Command(async () =>
                await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
    }
}

