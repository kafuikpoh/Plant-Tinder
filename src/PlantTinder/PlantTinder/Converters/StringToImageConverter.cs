using System;
using System.Linq;
using System.Globalization;
using Xamarin.Forms;

namespace PlantTinder.Converters
{
    public class StringToImageConverter : IValueConverter
    {
        //TODO: complete converter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var src = "";

            if((string)value == "potted-black.png")
            {
                src = "potted-white.png";
            }
            else if((string)value == "cactus-black.png")
            {
                src = "cactus-white.png";
            }
            else
            {
                src = "orchid-white.png";
            }

            return src;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
