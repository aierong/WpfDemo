using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.Views.BindData.contexts.basedemo
{
    /// <summary>
    /// ViewModel继承基类
    /// </summary>
    public class DataViewModel2 : ViewModelBase
    {
        public DataViewModel2 ()
        {
            Name = "Name_init";
            Title = "Titleinit";


            ShowCommand = new MyCommand2( ( string titleval ) =>
            {
                //接收到命令传递过来的一个参数
                MessageBox.Show( "show Command:" + titleval );

                Name = "改了";
                Title = "gai le title";

            } );
        }

        public MyCommand2 ShowCommand
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

                //通知数据已经变化
                OnPropertyChanged();
                //通知数据已经变化 
                OnPropertyChanged( "Description" );
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
                OnPropertyChanged();
                //通知数据已经变化
                OnPropertyChanged( "Description" );
            }
        }

        private string description;

        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get => string.Format( "{0}---{1}" , name , title );
            set
            {
                description = value;
            }
        }


 
    }
}
