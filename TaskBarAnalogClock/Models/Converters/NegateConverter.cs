using System;
using System.Globalization;
using System.Windows.Data;

namespace Cafemoca.TaskBarAnalogClock.Models.Converters
{
    public class NegateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case int i:
                    return -i;
                case double d:
                    return -d;
                case long l:
                    return -l;
                case bool b:
                    return !b;
                default:
                    throw new NotSupportedException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
