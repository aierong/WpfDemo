using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp.Views.ResourceDemo.ViewModels;

namespace WpfApp.Views.ResourceDemo.Views
{
    /// <summary>
    /// ResourceWindow.xaml 的互動邏輯
    /// </summary>
    public partial class ResourceWindow : Window
    {
        public ResourceWindow ()
        {
            InitializeComponent();

            this.DataContext = new ResourceWindowViewModel();
        }

        private void Button_Click ( object sender , RoutedEventArgs e )
        {
            //加载资源，可以用这2个方法： FindResource TryFindResource
            //                        TryFindResource如果加载不存在资源，返回null，不异常
            //                        FindResource如果加载不存在资源，会异常

            var obj1 = this.FindResource( "ComboBoxTitleWin" );

            //下面2个取到的变量已经不一样的，因为ComboBoxTitle在本窗体已经重新定义了
            var obj22 = Application.Current.FindResource( "ComboBoxTitle" );
            var obj21 = this.FindResource( "ComboBoxTitle" );

            var obj3 =  this.TryFindResource( "num1" );

            //myStackPanel 
            var obj4 = myStackPanel.TryFindResource( "Title123" );
             
        }
        
    }
}
