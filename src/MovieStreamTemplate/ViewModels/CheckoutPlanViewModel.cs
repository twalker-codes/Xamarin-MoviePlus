using System;
using System.Numerics;
using MovieStreamTemplate.Helpers;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class CheckoutPlanViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command ChooseFreeCommand { get; }
        public Command ChooseStandardCommand { get; }
        public Command ChoosePremiumCommand { get; }

        public CheckoutPlanViewModel()
        {
            ChooseFreeCommand = new Command(async () =>
            {
                var person = await service.GetPersonAsync(Globals.LoggedPersonId);
                person.Plan = Plan.FREE;
                await service.UpdatePersonAsync(person);

                await Shell.Current.GoToAsync("..");
            });

            ChooseStandardCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(CheckoutPaymentPage)}" +
                                        $"?{nameof(CheckoutPaymentViewModel.Plan)}={Plan.STANDARD.FriendlyName()}"));

            ChoosePremiumCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(CheckoutPaymentPage)}" +
                                        $"?{nameof(CheckoutPaymentViewModel.Plan)}={Plan.PREMIUM.FriendlyName()}"));
        }

    }
}

