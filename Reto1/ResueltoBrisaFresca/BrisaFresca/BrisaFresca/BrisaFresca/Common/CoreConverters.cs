using System;
using System.Globalization;
using Xamarin.Forms;

namespace BrisaFresca.Common
{
    public class UpdatedLabelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? "" : "Actualizado el " + (System.Convert.ToDateTime(value).ToString("h:mm tt")).ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
