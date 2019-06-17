using System;
using System.Globalization;
using DropPlus.Enums;
using Xamarin.Forms;

namespace DropPlus.Converters
{
    public class SeasonUkrTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }
            switch ((SeasonEnum)value)
            {
                case SeasonEnum.Autumn:
                    return "Осінь";
                case SeasonEnum.Winter:
                    return "Зима";
                case SeasonEnum.Spring:
                    return "Весна";
                case SeasonEnum.Summer:
                    return "Літо";
            }

            throw new Exception("Not known season: " + ((SeasonEnum)value));
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case "Осінь":
                    return SeasonEnum.Autumn;
                case "Зима":
                    return SeasonEnum.Winter;
                case "Весна":
                    return SeasonEnum.Spring;
                case "Літо":
                    return SeasonEnum.Summer;
            }

            throw new Exception("Not known season: " + ((SeasonEnum)value));
        }
    }
}