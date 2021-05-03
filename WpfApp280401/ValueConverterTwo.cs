using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp280401
{
    public class ValueConverterTwo: IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((double)value >= 30 && (double)value <= 55)
                return "Small";
            else if ((double)value > 55 && (double)value <= 80)
                return "Medium";
            else if ((double)value > 80 && (double)value <= 105)
                return "Large";
            else
                return "Extra Large";
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
