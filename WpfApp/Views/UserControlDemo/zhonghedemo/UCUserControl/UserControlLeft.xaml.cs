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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp.Views.UserControlDemo.zhonghedemo.UCUserControl
{
    /// <summary>
    /// UserControlLeft.xaml 的互動邏輯
    /// </summary>
    public partial class UserControlLeft : UserControl
    {
        public UserControlLeft ()
        {
            InitializeComponent();

            this.DataContext = new UserControlLeftViewModel();

        }
    }
}
