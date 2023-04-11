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
using WpfApp.Views.ValidationData.demo1.viewmodel;



namespace WpfApp.Views.ValidationData.demo1.view
{
    /// <summary>
    /// Yz.xaml 的互動邏輯
    /// </summary>
    public partial class Yz : Window
    {
        public Yz ()
        {
            InitializeComponent();

            this.DataContext = new YzViewModel();
        }
    }
}
