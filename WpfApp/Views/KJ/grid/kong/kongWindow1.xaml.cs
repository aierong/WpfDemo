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

namespace WpfApp.Views.KJ.grid.kong
{
    /// <summary>
    /// kongWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class kongWindow1 : Window
    {
        public kongWindow1 ()
        {
            InitializeComponent();

            this.DataContext = new kongWindow1VM();
        }
    }
}
