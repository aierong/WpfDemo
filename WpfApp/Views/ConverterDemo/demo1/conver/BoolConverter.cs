using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;



namespace WpfApp.Views.ConverterDemo.demo1.conver
{
    public class BoolConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            //viewmodel中的值，转换为view中的值 

            //parameter可以收到xaml中ConverterParameter传递的值
            if ( parameter != null )
            {
            }

            object obj = value;
            if ( obj is bool )
            {
                bool path = ( bool ) obj;

                return path ? "真" : "假";
            }

            return "假";
        }



        public object ConvertBack ( object value , Type targetType , object parameter , CultureInfo culture )
        {
            //当界面的值发生变化时，会调用该方法 view中的值转换为viewmodel


            if ( value != null )
            {
                if ( !string.IsNullOrEmpty( value.ToString() ) )
                {
                    if ( value.ToString() == "真" )
                    {
                        return true;
                    }
                }
            }

            return false;
        }



    }
}
