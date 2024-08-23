using System;
using System.Globalization;
using MovieStreamTemplate.Helpers;
using MovieStreamTemplate.Models;
using Xamarin.Forms;

namespace MovieStreamTemplate.Converters
{
    public class MovieGenreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((MovieGenre)value)
            {
                case MovieGenre.ACTION: return MovieGenre.ACTION.FriendlyName();
                case MovieGenre.ADVENTURE: return MovieGenre.ADVENTURE.FriendlyName();
                case MovieGenre.FANTASY: return MovieGenre.FANTASY.FriendlyName();
                case MovieGenre.HORROR: return MovieGenre.HORROR.FriendlyName();
                case MovieGenre.MYSTERY: return MovieGenre.MYSTERY.FriendlyName();
                case MovieGenre.SCIENCE_FICTION: return MovieGenre.SCIENCE_FICTION.FriendlyName();
                case MovieGenre.THRILLER: return MovieGenre.THRILLER.FriendlyName();
                default: return "Unkonown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

