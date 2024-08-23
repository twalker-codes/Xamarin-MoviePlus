using System;
using System.Globalization;
using MovieStreamTemplate.ControlTemplates;
using Xamarin.Forms;

namespace MovieStreamTemplate.Converters
{
    public class ShowcaseSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ShowcaseSize)value)
            {
                case ShowcaseSize.MEDIUM: return 170;
                default: return 240;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

