using System;
using System.Globalization;
using Xamarin.Forms;

namespace PlantTinder.Converters
{
    public class BoolToTextColor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Color.FromHex("#FFFFFF") : Color.FromHex("#4F4F4F");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Color)value == Color.FromHex("#FFFFFF") ? true : false;
        }
    }
}
