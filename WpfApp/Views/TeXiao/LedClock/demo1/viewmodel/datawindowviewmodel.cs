using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Xml.Linq;
using WpfApp.Views.ValidationData.demo1.viewmodel;

namespace WpfApp.Views.TeXiao.LedClock.demo1.viewmodel
{
    public class datawindowviewmodel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime timer;
        public DateTime Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Timer" ) );
            }
        }

        private void TimerEventHandler ( Object sender , EventArgs args )
        {
            Timer = DateTime.Now;
        }

        public datawindowviewmodel ()
        {

            Timer = DateTime.Now;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds( 1000 );

            timer.Tick += new EventHandler( TimerEventHandler );
            timer.IsEnabled = true;
            timer.Start();

        }
    }
}
