using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


//INotifyPropertyChanged 需要实现接口

namespace WpfApp.Views.BindData.contexts
{

    public class DataViewModel1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DataViewModel1 ()
        {
            Name = "Name_init";
            Title = "Titleinit";

            ShowCommand = new MyCommand( Show );
        }

        public MyCommand ShowCommand
        {
            get; set;
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

                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
            }
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

                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Title" ) );
            }
        }

        public void Show ()
        {
            Name = "改了";
            Title = "gai le title";

            MessageBox.Show( "show Command" );
        }

    }
}
