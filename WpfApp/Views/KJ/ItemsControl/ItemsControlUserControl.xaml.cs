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

namespace WpfApp.Views.KJ.ItemsControl
{
    /// <summary>
    /// ItemsControlUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class ItemsControlUserControl : UserControl
    {
        public ItemsControlUserControl ()
        {
            InitializeComponent();
            this.DataContext = new ItemsControlViewModel();
        }
    }
}
