using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Cafemoca.TaskBarAnalogClock.Models.Converters
{
    internal class HalfValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case int i:
                    return i / 2;
                case double d:
                    return d / 2;
                case long l:
                    return l / 2;
                case Point p:
                    return new Point(p.X / 2, p.Y / 2);
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
