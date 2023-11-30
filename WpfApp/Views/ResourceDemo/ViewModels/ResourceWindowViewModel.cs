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

        //
        public MyCommand UCommand
        {
            get; set;
        }

        public ResourceWindowViewModel ()
        {
            DataCommand = new MyCommand( () =>
            {

                //viewmodel中暂时只会访问,App.xaml中定义的资源
                var obj1 = Application.Current.TryFindResource( "ComboBoxTitle" );

                if ( obj1 != null )
                {
                }

            } );

            UCommand = new MyCommand( () =>
            {
                //可以修改,App.xaml中定义的资源
                Application.Current.Resources["RedBrush"] = new SolidColorBrush( Colors.Yellow );

                Application.Current.Resources["btntext"] =  DateTime.Now.ToLongTimeString ();

                //如果是ResourceWindow.xaml.cs文件请用下面方式改变资源
                //this.Resources["RedBrush"] = new SolidColorBrush(Colors.Yellow);

            } );
        }
    }
}
