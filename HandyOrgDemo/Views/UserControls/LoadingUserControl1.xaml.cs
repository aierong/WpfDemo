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
using HandyOrgDemo.ViewModels.UserControls;

namespace HandyOrgDemo.Views.UserControls
{
    /// <summary>
    /// LoadingUserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class LoadingUserControl1 : UserControl
    {
        public LoadingUserControl1 ()
        {
            InitializeComponent();

            this.DataContext = new LoadingViewModel();
        }
    }
}
