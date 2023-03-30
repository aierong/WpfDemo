using System;
using System.Collections.Generic;

using System.Linq;
using System.Printing.IndexedProperties;
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

        private bool isEnabled = false;

        /// <summary>
        /// 是否可以使用
        /// </summary>
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                SetProperty( ref isEnabled , value );

                //通知命令 已经改变
                ButtonClickCommand.NotifyCanExecuteChanged();
            }
        }

        /// <summary>
        /// 命令
        /// </summary>
        public RelayCommand ButtonClickCommand
        {
            get;
        }

        public DataViewModel1 ()
        {
            //RelayCommand的第一个参数是命令调用语句
            //              第2个参数(可选)是否允许使用
            ButtonClickCommand = new RelayCommand( () =>
            {
                //点击按钮,修改标题
                Title = "hello(改)";


                //System.Diagnostics.Debug.WriteLine( "ButtonClickCommand 1" );

            } , () =>
            {
                return IsEnabled;
            } );

            ButtonClickCommandPar = new RelayCommand<double>( ( double val ) =>
            {
                Title = $"hello(改):{val}";
            } );

            AsyncButtonClickCommand = new AsyncRelayCommand( RunTxtAsync );
            AsyncButtonParClickCommand = new AsyncRelayCommand<double>( RunTxtParAsync );

        }


        public RelayCommand<double> ButtonClickCommandPar
        {
            get;
        }

        /*
        特别说明：异步命令会自动控制控件的可见性,并且提供一个IsRunning属性可以判断异步是否完成
        */

        /// <summary>
        /// 命令
        /// </summary>
        public IAsyncRelayCommand AsyncButtonClickCommand
        {
            get;
        }


        private async Task RunTxtAsync ()
        {
            await Task.Delay( 4800 );
            Title = "hello(Task改)";


        }



        /// <summary>
        /// 命令
        /// </summary>
        public IAsyncRelayCommand<double> AsyncButtonParClickCommand
        {
            get;
        }



        private async Task RunTxtParAsync ( double val )
        {
            await Task.Delay( 4800 );
            Title = $"hello(Task改):{val}";


        }
    }
}
