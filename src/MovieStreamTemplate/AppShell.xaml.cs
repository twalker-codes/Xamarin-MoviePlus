using System;
using System.Collections.Generic;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AccountEditPage), typeof(AccountEditPage));
            Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
            Routing.RegisterRoute(nameof(CheckoutCompletedPage), typeof(CheckoutCompletedPage));
            Routing.RegisterRoute(nameof(CheckoutPaymentPage), typeof(CheckoutPaymentPage));
            Routing.RegisterRoute(nameof(CheckoutPlanPage), typeof(CheckoutPlanPage));
            Routing.RegisterRoute(nameof(FilterPage), typeof(FilterPage));
            Routing.RegisterRoute(nameof(HelpPage), typeof(HelpPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MovieDetailPage), typeof(MovieDetailPage));
            Routing.RegisterRoute(nameof(MoviesPage), typeof(MoviesPage));
            Routing.RegisterRoute(nameof(NewReviewPage), typeof(NewReviewPage));
            Routing.RegisterRoute(nameof(ProfileEditPage), typeof(ProfileEditPage));
            Routing.RegisterRoute(nameof(ResetPasswordPage), typeof(ResetPasswordPage));
            Routing.RegisterRoute(nameof(ReviewsPage), typeof(ReviewsPage));
            Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
            Routing.RegisterRoute(nameof(SettingPage), typeof(SettingPage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
        }

    }
}

