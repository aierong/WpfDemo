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

namespace WpfApp.Views.BindData.contexts
{
    /// <summary>
    /// dataWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class dataWindow1 : Window
    {
        public dataWindow1 ()
        {
            InitializeComponent();

            this.DataContext = new DataViewModel1();
        }
    }
}
