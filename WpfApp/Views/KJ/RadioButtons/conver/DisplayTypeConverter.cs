using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp.Views.KJ.RadioButtons.conver
{
    public class DisplayTypeConverter : IValueConverter
    {
        public object Convert ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            //value:就是xaml传递过来的枚举值
            //parameter:转换器参数，也是枚举值
            return value.Equals( parameter );
        }

        public object ConvertBack ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            //value:布尔值  RadioButton控件的IsChecked
            //parameter:转换器参数，也是枚举值
            if ( value is bool b && b )
            {
                return parameter;
            }

            //什么都不干
            return Binding.DoNothing;
        }
    }
}
