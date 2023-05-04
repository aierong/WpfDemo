using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.CommandDemo.demo1
{
    public class duoViewModel : ViewModelBase
    {
        public duoViewModel ()
        {
            Name = "Name_init";
            Title = "Titleinit";
            Title2 = "Titleinit2";

            SaveDataCommand = new MyObjCommand( ( object obj ) =>
            {
                //obj是传递过来的参数
                if ( obj != null )
                {
                    //obj是一个数组
                    var arr = ( object[] ) obj;
                    string _title = arr[0].ToString();
                    string _name = arr[1].ToString();
                    var gao = Convert.ToInt32( arr[2] );
                }

                Name = "改了";
                Title = "gai le title";

            } );

            EnterCommand = new MyCommand( () =>
            {

                MessageBox.Show( "EnterCommand Command:" + Title2 );
            } );
        }



        public MyObjCommand SaveDataCommand
        {
            get; set;
        }



        public MyCommand EnterCommand
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

            }
        }



        private string title2;


        /// <summary>
        /// 标题
        /// </summary>
        public string Title2
        {
            get => title2;

            set
            {
                title2 = value;

                //通知数据已经变化
                OnPropertyChanged();

            }
        }

    }
}
