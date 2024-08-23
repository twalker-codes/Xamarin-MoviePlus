using System;
using System.Collections.Generic;
using MovieStreamTemplate.ViewModels;
using Xamarin.Forms;

namespace MovieStreamTemplate.Views
{
    public partial class SearchPage : ContentPage
    {
        SearchViewModel viewModel;

        public SearchPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new SearchViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }
    }
}

