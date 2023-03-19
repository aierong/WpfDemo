using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

// 继承ObservableObject

namespace WpfDemoNet6.Demo
{
    public class DataViewModel1 : ObservableObject
    {
        private string title = "hello";

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                //title = value;
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );

                //SetProperty 相当与设置值,并且PropertyChanged通知调用
                SetProperty( ref title , value );
            }
        }

        public RelayCommand ButtonClickCommand
        {
            get;
        }

        public DataViewModel1 ()
        {
            ButtonClickCommand = new RelayCommand( () =>
            {
                //点击按钮,修改标题
                Title = "hello(改)";
            } );
        }
    }
}
