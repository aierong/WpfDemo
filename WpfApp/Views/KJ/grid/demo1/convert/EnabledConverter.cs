using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp.Views.KJ.grid.demo1.convert
{
    public class EnabledConverter : IValueConverter
    {
        public object Convert ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            if ( value != null )
            {
                var val = int.Parse( value.ToString() );

                return val >= 16;
            }

            return true;
        }

        public object ConvertBack ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
