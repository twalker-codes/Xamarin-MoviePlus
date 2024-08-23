using System;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class CheckoutCompletedViewModel: BaseViewModel
    {
        public Command ContinueCommand { get; }

        public CheckoutCompletedViewModel()
        {
            ContinueCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"//tabbar/myprofile"));
        }
    }
}

