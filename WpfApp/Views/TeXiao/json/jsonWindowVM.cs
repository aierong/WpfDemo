using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.TeXiao.json
{
    public class jsonWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MyCommand UpdateDataCommand
        {
            get; set;
        }

        public jsonWindowVM ()
        {
            B1 = false;

            str1 = "pack://application:,,,/assets/json/bg.json";

            UpdateDataCommand = new MyCommand( () =>
            {

                B1 = !B1;

                if ( B1 )
                {
                    str1 = "pack://application:,,,/assets/json/notxinhao.json";
                }
                else
                {
                    str1 = "pack://application:,,,/assets/json/bg.json";
                }

            } );
        }

        public bool _b1;
        public bool B1
        {
            get
            {
                return _b1;
            }
            set
            {
                _b1 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "B1" ) );
            }
        }

        public string _str1;
        public string str1
        {
            get
            {
                return _str1;
            }
            set
            {
                _str1 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "str1" ) );
            }
        }

    }
}
