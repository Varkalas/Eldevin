using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Globalization;

namespace EldevinAssistant
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            return (value is bool && (bool)value) ? Visibility.Visible : Visibility.Hidden;
            /* Mine
             * ------------
            if (!(value is bool))
                return Visibility.Hidden;
            if ((bool)value)
                return Visibility.Visible;
            return Visibility.Hidden; */
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            return value is Visibility && (Visibility)value == Visibility.Visible;
            /* My lame code
             * ------------
            if (value is Visibility.Visible)
                return true;
            if (value is Visibility.Hidden)
                return null;
            return null; */
        }
    }
}
