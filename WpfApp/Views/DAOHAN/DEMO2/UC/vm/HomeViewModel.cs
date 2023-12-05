using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.DAOHAN.DEMO2.UC.vm
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged ( string propName )
        {
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( propName ) );
        }
        public HomeViewModel()
        {
        }
    }
}
