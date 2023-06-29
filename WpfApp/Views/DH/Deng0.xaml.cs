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

namespace WpfApp.Views.DH
{
    /// <summary>
    /// Window5.xaml 的交互逻辑
    /// </summary>
    public partial class Deng0 : Window
    {
        public Deng0 ()
        {
            InitializeComponent();

            this.DataContext = new Deng0ViewModel();
        }
    }
}
