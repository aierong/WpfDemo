using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp.Views.KJ.grid.tiaojianxianshi
{
    public class BooleanToVisibilityConverterNew : IValueConverter
    {
        public object Convert ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            if ( parameter != null )
            {
                var b = ( bool ) value;

                if ( parameter.ToString() != "1" )
                {
                    b = !b;
                }

                return b ? Visibility.Visible : Visibility.Collapsed;
            }

            return ( bool ) value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
