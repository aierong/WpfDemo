using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.DAOHAN.DEMO2.UC.vm
{
    public  class DesktopViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged ( string propName )
        {
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( propName ) );
        }


        public MyCommand UpdateDataCommand
        {
            get; set;
        }



        public DesktopViewModel()
        {
            Str1 = DateTime.Now.ToLongTimeString();

            UpdateDataCommand = new MyCommand( () =>
            {

                Str1 = $"{DateTime.Now.ToString( "HH:mm:ss" )}gai le";

            } );
        }


        public string str1;
        public string Str1
        {
            get
            {
                return str1;
            }
            set
            {
                str1 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Str1" ) );
            }
        }



    }
}
