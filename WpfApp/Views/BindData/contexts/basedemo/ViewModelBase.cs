using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//定义一个基类

namespace WpfApp.Views.BindData.contexts.basedemo
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged ( [CallerMemberName] string PropertyName = "" )
        {
            //通知数据已经变化
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( PropertyName ) );
        }
    }
}
