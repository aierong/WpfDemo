using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.TeXiao.GeometryDemo
{
    public class WindowGeometryviewmodel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public WindowGeometryviewmodel ()
        {
            B1 = false;

            UpdateDataCommand = new MyCommand( () =>
            {

                B1 = !B1;

            } );
        }

        public MyCommand UpdateDataCommand
        {
            get; set;
        }



    }
}
