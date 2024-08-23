using System;
using System.Collections.Generic;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MovieStreamTemplate.ControlTemplates
{
    public partial class ChicEntry : ContentView
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(ChicEntry), string.Empty, BindingMode.TwoWay);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ChicEntry()
        {
            InitializeComponent();
        }
    }
}

