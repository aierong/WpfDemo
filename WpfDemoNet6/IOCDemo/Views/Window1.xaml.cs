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
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WpfDemoNet6.IOCDemo.ViewModels;

namespace WpfDemoNet6.IOCDemo.Views
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1 ()
        {

            InitializeComponent();

            // this.DataContext = new WindowViewModel1(); 这样不可以使用了,请用App.Current.Services.GetService
            this.DataContext = App.Current.Services.GetService<WindowViewModel1>();

            //代码任何处,都可以使用App.Current.Services.GetService获取到服务
            //IFilesService filesService = App.Current.Services.GetService<IFilesService>();


        }
    }
}
