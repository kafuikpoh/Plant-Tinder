using System;
using System.Globalization;
using Xamarin.Forms;

namespace PlantTinder.Converters
{
    public class BoolToColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Color.FromHex("#528665") : Color.FromHex("#F3F5F7");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Color)value == Color.FromHex("#528665") ? true : false;
        }
    }
}
