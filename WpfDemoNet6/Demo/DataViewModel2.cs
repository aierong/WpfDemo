using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

/*
这里演示自动生成属性和命令

1.继承ObservableObject 并且类标记是分部类partial
2.私有变量标记属性 [ObservableProperty]
*/

namespace WpfDemoNet6.Demo
{
    public partial class DataViewModel2 : ObservableObject
    {
        /*
        [ObservableProperty]标记后,会自动生成属性(大写命名),例如:下面自动生成Title

        注意:这个私有变量命名:必须是小写开头,或者下划线,或者m_
        */

        [ObservableProperty]
        private string title = "hello";

        //public string Title
        //{
        //    get
        //    {
        //        return title;
        //    }
        //    set
        //    {
        //        //title = value;
        //        //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );

        //        //SetProperty 相当与设置值,并且PropertyChanged通知调用
        //        SetProperty( ref title , value );
        //    }
        //}


        [ObservableProperty]
        private bool isEnabled = false;


        public RelayCommand ButtonClickCommand
        {
            get;
        }

        public DataViewModel2 ()
        {
            //RelayCommand的第一个参数是命令调用语句
            //              第2个参数(可选)是否允许使用
            ButtonClickCommand = new RelayCommand( () =>
            {
                //点击按钮,修改标题
                Title = "hello(改)";
            } , () =>
            {
                return IsEnabled;
            } );

            ButtonClickCommandPar = new RelayCommand<double>( ( double val ) =>
            {
                Title = $"hello(改):{val}";
            } );
        }


        public RelayCommand<double> ButtonClickCommandPar
        {
            get;
        }
    }
}
