using System;
using System.Globalization;
using DropPlus.Enums;
using Xamarin.Forms;

namespace DropPlus.Converters
{
    public class SeasonImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }
            switch ((SeasonEnum) value)
            {
                case SeasonEnum.Autumn:
                    return "autumn.png";
                case SeasonEnum.Winter:
                    return "winter.png";
                case SeasonEnum.Spring:
                    return "spring.png";
                case SeasonEnum.Summer:
                    return "summer.png";
            }

            throw new Exception("Not known season: " + ((SeasonEnum)value));
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}