using System;
using System.Globalization;
using Xamarin.Forms;

namespace MovieStreamTemplate.Converters
{
    public class PosterHeightConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * 1.5; // Poster aspect ratio
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

