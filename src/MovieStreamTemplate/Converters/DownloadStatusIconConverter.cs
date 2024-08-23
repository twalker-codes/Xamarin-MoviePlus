using System;
using System.Globalization;
using MovieStreamTemplate.MaterialDesign;
using MovieStreamTemplate.Models;
using Xamarin.Forms;

namespace MovieStreamTemplate.Converters
{
    public class DownloadStatusIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((DownloadStatus)value)
            {
                case DownloadStatus.Downloaded: return Icons.DownloadDone;
                case DownloadStatus.Downloading: return Icons.Downloading;
                default: return Icons.Download;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

