using System;
using System.Globalization;
using MovieStreamTemplate.Models;
using Xamarin.Forms;

namespace MovieStreamTemplate.Converters
{
    public class DownloadStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((DownloadStatus)value)
            {
                case DownloadStatus.Downloaded: return "Downloaded";
                case DownloadStatus.Downloading: return "Downloading";
                default: return "No Download";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

