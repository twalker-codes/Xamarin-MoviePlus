using System;
using MovieStreamTemplate.Helpers;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.Services;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    [QueryProperty(nameof(Plan), nameof(Plan))]
    public class CheckoutPaymentViewModel: BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command CheckoutCommand { get; }

        private Plan plan;
        public string Plan
        {
            get => plan.FriendlyName();
            set
            {
                SetProperty(ref plan, value.PlanFromFriendlyName());
                OnPropertyChanged(nameof(SelectedPlan));
                OnPropertyChanged(nameof(Price));
            }
        }

        public string SelectedPlan
        {
            get => plan.FriendlyName();
        }

        public float Price
        {
            get
            {
                switch(plan)
                {
                    case Models.Plan.PREMIUM: return 160f;
                    case Models.Plan.STANDARD: return 80f;
                    default: return 0f;
                }
            }
        }

        private string cardOwner;
        public string CardOwner
        {
            get => cardOwner;
            set => SetProperty(ref cardOwner, value);
        }

        private string cardNumber;
        public string CardNumber
        {
            get => cardNumber;
            set => SetProperty(ref cardNumber, value);
        }

        private string month;
        public string Month
        {
            get => month;
            set => SetProperty(ref month, value);
        }

        private string year;
        public string Year
        {
            get => year;
            set => SetProperty(ref year, value);
        }

        private string cvc;
        public string Cvc
        {
            get => cvc;
            set => SetProperty(ref cvc, value);
        }

        public CheckoutPaymentViewModel()
        {
            CheckoutCommand = new Command(async () =>
            {
                var person = await service.GetPersonAsync(Globals.LoggedPersonId);
                person.Plan = plan;
                await service.UpdatePersonAsync(person);

                await Shell.Current.GoToAsync($"{nameof(CheckoutCompletedPage)}");
            });
        }
    }
}

