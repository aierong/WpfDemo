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
                // 命令根据xaml传递过来参数，切换不同vm
                switch ( str )
                {
                    case "Home":
                        MainContent = new UC.vm.HomeViewModel();
                        break;

                    case "DesktopData":
                        MainContent = new UC.vm.DesktopViewModel();
                        break;

                    case "Setup":
                        MainContent = new UC.vm.SetupViewModel();
                        break;

                    default:
                        MainContent = new UC.vm.HomeViewModel();
                        break;
                }
            } );

        }
    }
}
