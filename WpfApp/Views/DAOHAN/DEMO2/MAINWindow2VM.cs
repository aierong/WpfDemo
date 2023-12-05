using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.DAOHAN.DEMO2
{
    public class MAINWindow2VM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged ( string propName )
        {
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( propName ) );
        }

        private object _MainContent;
        public object MainContent
        {
            get => _MainContent;
            set
            {
                _MainContent = value;

                OnPropertyChanged( "MainContent" );
            }
        }


        public MyParCommand<string> OpenCommand
        {
            get; set;
        }


        public MAINWindow2VM ()
        {
            MainContent = new UC.vm.HomeViewModel();

            OpenCommand = new MyParCommand<string>( ( string str ) =>
            {
                switch ( str )
                {
                    case "Home":
                        MainContent = new UC.vm.HomeViewModel();
                        break;

                    case "DesktopData":
                        MainContent = new UC.vm.DesktopViewModel();
                        break;

                    default:
                        MainContent = new UC.vm.HomeViewModel();
                        break;
                }
            } );

        }
    }
}
