using System;
using System.Globalization;
using MovieStreamTemplate.Models;
using Xamarin.Forms;

namespace MovieStreamTemplate.Converters
{
    public class DownloadStatusShowHideConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (DownloadStatus)value == DownloadStatus.NoDownload ? false : true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

