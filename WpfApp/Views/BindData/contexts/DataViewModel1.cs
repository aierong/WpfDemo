using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.BaseCommand;


//定义ViewModel类实现接口: INotifyPropertyChanged 

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
            Title = "gai le title";

            MessageBox.Show( "show Command" );
        }

    }
}
