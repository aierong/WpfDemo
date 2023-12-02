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

            setuptime( Timer );


            var i = 0;
            var a = 100 / i;
        }



        void setuptime ( DateTime now )
        {
            int _h = now.Hour;

            if ( _h >= 10 )
            {
                Hour1 = getcode( Convert.ToInt32( _h.ToString().Substring( 0 , 1 ) ) );
                Hour2 = getcode( Convert.ToInt32( _h.ToString().Substring( 1 ) ) );

                SvgHour1 = getsvgcode( Convert.ToInt32( _h.ToString().Substring( 0 , 1 ) ) );
                SvgHour2 = getsvgcode( Convert.ToInt32( _h.ToString().Substring( 1 ) ) );
            }
            else
            {
                Hour1 = getcode( 0 );
                Hour2 = getcode( _h );

                SvgHour1 = getsvgcode( 0 );
                SvgHour2 = getsvgcode( _h );
            }

            int _m = now.Minute;

            if ( _m >= 10 )
            {
                Minute1 = getcode( Convert.ToInt32( _m.ToString().Substring( 0 , 1 ) ) );
                Minute2 = getcode( Convert.ToInt32( _m.ToString().Substring( 1 ) ) );


                SvgMinute1 = getsvgcode( Convert.ToInt32( _m.ToString().Substring( 0 , 1 ) ) );
                SvgMinute2 = getsvgcode( Convert.ToInt32( _m.ToString().Substring( 1 ) ) );
            }
            else
            {
                Minute1 = getcode( 0 );
                Minute2 = getcode( _m );

                SvgMinute1 = getsvgcode( 0 );
                SvgMinute2 = getsvgcode( _m );
            }

            int _s = now.Second;
            if ( _s >= 10 )
            {
                Second1 = getcode( Convert.ToInt32( _s.ToString().Substring( 0 , 1 ) ) );
                Second2 = getcode( Convert.ToInt32( _s.ToString().Substring( 1 ) ) );

                SvgSecond1 = this.getsvgcode( Convert.ToInt32( _s.ToString().Substring( 0 , 1 ) ) );
                SvgSecond2 = getsvgcode( Convert.ToInt32( _s.ToString().Substring( 1 ) ) );
            }
            else
            {
                Second1 = getcode( 0 );
                Second2 = getcode( _s );

                SvgSecond1 = getsvgcode( 0 );
                SvgSecond2 = getsvgcode( _s );
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

        #region svg

        public string _SvgHour1;
        public string SvgHour1
        {
            get
            {
                return _SvgHour1;
            }
            set
            {
                _SvgHour1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "SvgHour1" ) );
            }
        }

        public string _SvgHour2;
        public string SvgHour2
        {
            get
            {
                return _SvgHour2;
            }
            set
            {
                _SvgHour2 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "SvgHour2" ) );
            }
        }

        public string _SvgMinute1;
        public string SvgMinute1
        {
            get
            {
                return _SvgMinute1;
            }
            set
            {
                _SvgMinute1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "SvgMinute1" ) );
            }
        }

        public string _SvgMinute2;
        public string SvgMinute2
        {
            get
            {
                return _SvgMinute2;
            }
            set
            {
                _SvgMinute2 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "SvgMinute2" ) );
            }
        }


        public string _SvgSecond1;
        public string SvgSecond1
        {
            get
            {
                return _SvgSecond1;
            }
            set
            {
                _SvgSecond1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "SvgSecond1" ) );
            }
        }

        public string _SvgSecond2;
        public string SvgSecond2
        {
            get
            {
                return _SvgSecond2;
            }
            set
            {
                _SvgSecond2 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "SvgSecond2" ) );
            }
        }

        string getsvgcode ( int num )
        {

            return string.Format( "/assets/svg/{0}_{1}.svg" , num , num );
        }

        #endregion 


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
