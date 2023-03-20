using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WpfApp.Views.UserControlDemo.zhonghedemo.UCUserControl
{
    public class UserControlLeftViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UserControlLeftViewModel ()
        {
            Name = "Name_init";

            ShowCommand = new MyCommand( () =>
            {
                Name = "改了";

                MessageBox.Show( "ShowCommand Command" );
            } );
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



        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }




    }
}
