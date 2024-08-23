using System;
using System.Collections.Generic;
using MovieStreamTemplate.ViewModels;
using Xamarin.Forms;

namespace MovieStreamTemplate.Views
{
    public partial class MoviesPage : ContentPage
    {
        MoviesViewModel viewModel;

        public MoviesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MoviesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }
    }
}

