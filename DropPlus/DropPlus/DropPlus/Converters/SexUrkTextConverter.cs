using System;
using System.Globalization;
using DropPlus.Enums;
using Xamarin.Forms;

namespace DropPlus.Converters
{
    public class SexUkrTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }
            switch ((SexEnum)value)
            {
                case SexEnum.Man:
                    return "Чоловік";
                case SexEnum.Woman:
                    return "Жінка";
            }

            throw new Exception("Not known season: " + ((SeasonEnum)value));
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new NotImplementedException();
        }
    }
}