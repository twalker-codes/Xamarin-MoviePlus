using System;
using System.Collections.Generic;
using MovieStreamTemplate.ViewModels;
using Xamarin.Forms;

namespace MovieStreamTemplate.Views
{
    public partial class MyProfilePage : ContentPage
    {
        MyProfileViewModel viewModel;

        public MyProfilePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MyProfileViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }
    }
}

