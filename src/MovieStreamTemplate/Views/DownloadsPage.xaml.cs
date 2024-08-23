using System;
using System.Collections.Generic;
using MovieStreamTemplate.ViewModels;
using Xamarin.Forms;

namespace MovieStreamTemplate.Views
{
    public partial class DownloadsPage : ContentPage
    {
        DownloadsViewModel viewModel;

        public DownloadsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new DownloadsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }
    }
}

