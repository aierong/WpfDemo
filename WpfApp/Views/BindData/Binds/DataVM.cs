using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.BindData.Binds
{
    public class DataVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string str1;
        public string Str1
        {
            get
            {
                return str1;
            }
            set
            {
                str1 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Str1" ) );
            }
        }
    }
}
