﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp280401;
using System.Windows.Data;

namespace WpfApp280401
{
    public class ValueConverterOne: IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((double)value >=50 && (double)value<=100)
                return "Small";
            else if ((double)value >100  && (double)value <= 150)
                return "Medium";
            else if ((double)value > 150 && (double)value <= 200)
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
