using System;
using Avalonia.Data.Converters;
using System.Globalization;

namespace AvaloniaApplication2.ViewModels
{
    public class KeyToWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var key = value as string;
            if (key == "ENTER")
                return 100;
            else if (key == "RM")
                return 70;
            return 42;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
