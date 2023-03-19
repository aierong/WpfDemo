using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

//多个参数必须实现接口: IMultiValueConverter

namespace WpfApp.Views.CommandDemo.demo1
{
    public class ObjectConvert : IMultiValueConverter
    {
        public object Convert ( object[] values ,
            Type targetType ,
            object parameter ,
            CultureInfo culture )
        {
            //把数据Clone返回
            return values.Clone();
        }

        public object[] ConvertBack ( object value ,
            Type[] targetTypes ,
            object parameter ,
            CultureInfo culture )
        {
            //反向不管 没有用
            throw new NotImplementedException();
        }
    }
}
