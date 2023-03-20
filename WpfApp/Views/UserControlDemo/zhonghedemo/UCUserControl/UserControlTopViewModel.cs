using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.Views.UserControlDemo.zhonghedemo.UCUserControl
{
    public class UserControlTopViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// 命令
        /// </summary>
        public TopCommand ClickCommand
        {
            get; set;
        }


        public UserControlTopViewModel ()
        {
            Name = "Name_init";

            ClickCommand = new TopCommand( () =>
            {
                Name = "改了";

                MessageBox.Show( "TopCommand Command" );
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


    }
}
