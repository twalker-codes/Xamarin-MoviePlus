using System;
using System.Collections.Generic;
using MovieStreamTemplate.ViewModels;
using Xamarin.Forms;

namespace MovieStreamTemplate.Views
{
    public partial class ReviewsPage : ContentPage
    {
        ReviewsViewModel viewModel;

        public ReviewsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ReviewsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }
    }
}

