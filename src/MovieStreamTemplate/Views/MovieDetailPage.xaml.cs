using System;
using System.Collections.Generic;
using MovieStreamTemplate.ViewModels;
using Xamarin.Forms;

namespace MovieStreamTemplate.Views
{
    public partial class MovieDetailPage : ContentPage
    {
        MovieDetailViewModel viewModel;

        public MovieDetailPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MovieDetailViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }
    }
}

