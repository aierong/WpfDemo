using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;



namespace WpfApp.Views.KJ.grid.demo1.convert
{
    public class EnabledToConverter : IValueConverter
    {
        public object Convert ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            if ( value != null )
            {
                if ( value is Student )
                {
                    var obj = ( Student ) value;

                    return obj.Age >= 16 && obj.IsMan;
                }
            }

            return true;
        }

        public object ConvertBack ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
