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
using WpfDemoNet6.Demo.ListData.plus.ViewModels;



namespace WpfDemoNet6.Demo.ListData.plus.Views
{
    /// <summary>
    /// EmpList.xaml 的互動邏輯
    /// </summary>
    public partial class EmpList : Window
    {
        public EmpList ()
        {
            InitializeComponent();

            this.DataContext = new EmpListViewModel();
        }
    }
}
