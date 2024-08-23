using System;
using System.Collections.Generic;
using MovieStreamTemplate.MaterialDesign;
using MovieStreamTemplate.Models;
using MovieStreamTemplate.ViewModels;
using MovieStreamTemplate.Views;
using Xamarin.Forms;

namespace MovieStreamTemplate.ControlTemplates
{
    /// <summary>
    /// Movie cell view optimized for linear layout
    /// </summary>
    public partial class MovieLinearCell : ContentView
    {
        public static readonly BindableProperty MovieIdProperty =
            BindableProperty.Create(nameof(MovieId), typeof(string), typeof(MovieLinearCell), null);

        public static readonly BindableProperty PosterProperty =
            BindableProperty.Create(nameof(Poster), typeof(string), typeof(MovieLinearCell), null);

        public static readonly BindableProperty ShowBookmarkProperty =
            BindableProperty.Create(nameof(ShowBookmark), typeof(bool), typeof(MovieLinearCell), false);

        public static readonly BindableProperty StatusProperty =
            BindableProperty.Create(nameof(Status), typeof(DownloadStatus), typeof(MovieLinearCell), DownloadStatus.NoDownload);

        public static readonly BindableProperty MovieTappedCommandProperty =
            BindableProperty.Create(nameof(MovieTappedCommand), typeof(Command<string>), typeof(MovieLinearCell), null);

        public static readonly BindableProperty AverageRatingProperty =
            BindableProperty.Create(nameof(AverageRating), typeof(float), typeof(MovieLinearCell), 0f);

        public static readonly BindableProperty ShowRatingProperty =
            BindableProperty.Create(nameof(ShowRating), typeof(bool), typeof(MovieLinearCell), false);

        public string MovieId
        {
            get => (string)GetValue(MovieIdProperty);
            set => SetValue(MovieIdProperty, value);
        }

        /// <summary>
        /// Name of an image resource
        /// </summary>
        public string Poster
        {
            get => (string)GetValue(PosterProperty);
            set => SetValue(PosterProperty, value);
        }

        /// <summary>
        /// Show or hide bookmark icon at top-right corner
        /// </summary>
        public bool ShowBookmark
        {
            get => (bool)GetValue(ShowBookmarkProperty);
            set => SetValue(ShowBookmarkProperty, value);
        }

        public DownloadStatus Status
        {
            get => (DownloadStatus)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        public float AverageRating
        {
            get => (float)GetValue(AverageRatingProperty);
            set => SetValue(AverageRatingProperty, value);
        }

        /// <summary>
        /// Show or hide rating star at top-left corner
        /// </summary>
        public bool ShowRating
        {
            get => (bool)GetValue(ShowRatingProperty);
            set => SetValue(ShowRatingProperty, value);
        }

        /// <summary>
        /// The command to be executed when an item tapped.
        /// </summary>
        public Command<string> MovieTappedCommand
        {
            get => (Command<String>)GetValue(MovieTappedCommandProperty);
            set => SetValue(MovieTappedCommandProperty, value);
        }

        public MovieLinearCell()
        {
            InitializeComponent();

           MovieTappedCommand = new Command<string>(async (movieId) =>
                    await Shell.Current.GoToAsync($"{nameof(MovieDetailPage)}" +
                                                $"?{nameof(MovieDetailViewModel.MovieId)}={movieId}"));

        }
    }
}

