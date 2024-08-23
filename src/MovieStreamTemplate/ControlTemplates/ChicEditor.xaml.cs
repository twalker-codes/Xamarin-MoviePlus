using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MovieStreamTemplate.ControlTemplates
{
    public partial class ChicEditor : ContentView
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(ChicEditor), string.Empty, BindingMode.TwoWay);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ChicEditor()
        {
            InitializeComponent();
        }
    }
}

