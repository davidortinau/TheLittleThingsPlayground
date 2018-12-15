using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace WebinarDemos.Converters
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
			if (value == null)
				return Color.Default;
			
            string valueAsString = value.ToString();
            Debug.WriteLine(valueAsString);
            switch (valueAsString)
            {
                case (""):
                    {
                        return Color.Default;
                    }
                case ("Accent"):
                    {
                        return Color.Accent;
                    }
                default:
                    {
                        var converter = new ColorTypeConverter();
                        var result = converter.ConvertFromInvariantString(valueAsString);
                        return result;
                    }
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
