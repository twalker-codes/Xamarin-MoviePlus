using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MovieStreamTemplate.Models;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MovieStreamTemplate.ControlTemplates
{
    public partial class ShowcaseCard : ContentView
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(ShowcaseCard), string.Empty);

        public static readonly BindableProperty SizeProperty =
            BindableProperty.Create(nameof(Size), typeof(ShowcaseSize), typeof(ShowcaseCard), ShowcaseSize.MEDIUM);

        public static readonly BindableProperty MoviesProperty =
            BindableProperty.Create(nameof(Movies), typeof(ObservableCollection<Movie>), typeof(ShowcaseCard), null);

        public static readonly BindableProperty TitleCommandProperty =
            BindableProperty.Create(nameof(TitleCommand), typeof(Command), typeof(ShowcaseCard), null);


        /// <summary>
        /// The string to be displayed in the title.
        /// </summary>
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        /// <summary>
        /// Medium or large. Will determine the poster size.
        /// </summary>
        public ShowcaseSize Size
        {
            get => (ShowcaseSize)GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }

        /// <summary>
        /// Movie collection to list
        /// </summary>
        public ObservableCollection<Movie> Movies
        {
            get => (ObservableCollection<Movie>)GetValue(MoviesProperty);
            set => SetValue(MoviesProperty, value);
        }

        /// <summary>
        /// The command to be executed when the title is tapped.
        /// </summary>
        public Command TitleCommand
        {
            get => (Command)GetValue(TitleCommandProperty);
            set => SetValue(TitleCommandProperty, value);
        }

        public ShowcaseCard()
        {
            InitializeComponent();
        }
    }
}

