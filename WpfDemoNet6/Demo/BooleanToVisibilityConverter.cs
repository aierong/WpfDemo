using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;



namespace WpfDemoNet6.Demo
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            return ( bool ) value ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            if ( value is Visibility )
            {
                Visibility v = ( Visibility ) value;

                if ( v == Visibility.Visible )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
            
        }
    }
}
