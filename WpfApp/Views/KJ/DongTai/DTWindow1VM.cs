using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;
using WpfApp.Views.KJ.grid.tiaojianxianshi.Models;

namespace WpfApp.Views.KJ.DongTai
{
    public class DTWindow1VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MyCommand ReCommand
        {
            get; set;
        }

        public DTWindow1VM ()
        {
            //初始化

            Num1 = 1;

            ReCommand = new MyCommand( redata );
        }

        public void redata ()
        {

            Num1 = Num1 + 1;

            if ( Num1 >= 3 )
            {
                Num1 = 0;
            }

        }


        public int  _Num1;
        public int Num1
        {
            get
            {
                return _Num1;
            }
            set
            {
                _Num1 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Num1" ) );
            }
        }
    }
}
