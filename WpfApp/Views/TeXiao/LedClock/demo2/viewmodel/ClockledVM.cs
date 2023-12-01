using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp.Views.TeXiao.LedClock.demo2.viewmodel
{
    public class ClockledVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ClockledVM ()
        {

            var Timer = DateTime.Now;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds( 1000 );

            timer.Tick += new EventHandler( TimerEventHandler );
            timer.IsEnabled = true;
            timer.Start();

        }



        private void TimerEventHandler ( Object sender , EventArgs args )
        {
            var Timer = DateTime.Now;

            setuptime(Timer );
        }



        void setuptime ( DateTime now )
        {
            int _h = now.Hour;

            if ( _h >= 10 )
            {
               

                Hour1 = getcode( Convert.ToInt32( _h.ToString().Substring( 0,1 ) ) );
                Hour2 = getcode( Convert.ToInt32( _h.ToString().Substring( 1 ) ) );
            }
            else
            {
                //'0'
                Hour1 = getcode( 0 );
                Hour2 = getcode( _h );
            }

            int _m = now.Minute;

            if ( _m >= 10 )
            {
                

                Minute1 = getcode( Convert.ToInt32( _m.ToString().Substring( 0,1 ) ) );
                Minute2 = getcode( Convert.ToInt32( _m.ToString().Substring(  1 ) ) );
            }
            else
            {
                //'0'
                Minute1 = getcode( 0 );
                Minute2 = getcode( _m );
            }

            int _s = now.Second;
            if ( _s >= 10 )
            {

                Second1 = getcode( Convert.ToInt32( _s.ToString().Substring( 0 , 1 ) ) );
                Second2 = getcode( Convert.ToInt32( _s.ToString().Substring( 1 ) ) );
            }
            else
            {
                //'0'
                Second1 = getcode( 0 );
                Second2 = getcode( _s );
            }
        }



        string getcode ( int num )
        {
            if ( num == 1 )
            {
                return "\xe61e";
            }

            if ( num == 2 )
            {
                return "\xe621";
            }

            if ( num == 3 )
            {
                return "\xe627";
            }

            if ( num == 4 )
            {
                return "\xe626";
            }

            if ( num == 5 )
            {
                return "\xe620";
            }

            if ( num == 6 )
            {
                return "\xe622";
            }

            if ( num == 7 )
            {
                return "\xe623";
            }

            if ( num == 8 )
            {
                return "\xe624";
            }

            if ( num == 9 )
            {
                return "\xe625";
            }

            return "\xe61f";
        }

        
        public string _Second1;
        public string Second1
        {
            get
            {
                return _Second1;
            }
            set
            {
                _Second1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Second1" ) );
            }
        }

        public string _Second2;
        public string Second2
        {
            get
            {
                return _Second2;
            }
            set
            {
                _Second2 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Second2" ) );
            }
        }


        public string _Minute1;
        public string Minute1
        {
            get
            {
                return _Minute1;
            }
            set
            {
                _Minute1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Minute1" ) );
            }
        }

        public string _Minute2;
        public string Minute2
        {
            get
            {
                return _Minute2;
            }
            set
            {
                _Minute2 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Minute2" ) );
            }
        }

        public string _Hour1;
        public string Hour1
        {
            get
            {
                return _Hour1;
            }
            set
            {
                _Hour1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Hour1" ) );
            }
        }

        public string _Hour2;
        public string Hour2
        {
            get
            {
                return _Hour2;
            }
            set
            {
                _Hour2 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Hour2" ) );
            }
        }
    }
}
