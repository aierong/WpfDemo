using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.ConverterDemo.demo1.viewmodel
{
    public class WindowViewModel1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public WindowViewModel1 ()
        {
            Name = "Name_init";
            IsFlag = true;

            ShowCommand = new MyCommand( Show );
        }


        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }



        public void Show ()
        {
            Name = "改了";
            IsFlag = !IsFlag;

            //MessageBox.Show( "show Command" );
        }


        private string name;

        /// <summary>
        /// 名字
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
            }
        }



        private bool isflag;


        /// <summary>
        /// 标识
        /// </summary>
        public bool IsFlag
        {
            get => isflag;

            set
            {
                isflag = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "IsFlag" ) );
            }
        }



    }
}
