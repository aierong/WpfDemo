using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.DH
{
    public class Window1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Window1ViewModel ()
        {
            Title = "Titleinit";

            ShowCommand = new MyCommand( Show );
        }


        public void Show ()
        {

            Title = "gai le title" + DateTime.Now.ToLongTimeString();


        }


        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }


        private string title;


        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get => title;

            set
            {
                title = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Title" ) );
            }
        }

    }
}
