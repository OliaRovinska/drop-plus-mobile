using System;
using System.Globalization;
using Xamarin.Forms;

namespace DropPlus.Converters
{
    public class FavoriteImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)value) ? "heart_favourite.png" : "heart.png";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}