using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WpfApp.Properties;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.ResourceDemo.ViewModels
{
    public class ResourceWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MyCommand DataCommand
        {
            get; set;
        }

        public ResourceWindowViewModel ()
        {
            DataCommand = new MyCommand( () =>
            {

                //viewmodel中暂时只会访问,App.xaml中定义的资源
                var obj1 = Application.Current.TryFindResource( "ComboBoxTitle" );


                
            } );
        }
    }
}
