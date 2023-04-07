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

namespace WpfApp.Views.KJ
{
    /// <summary>
    /// mainpage.xaml 的互動邏輯
    /// </summary>
    public partial class mainpage : Window
    {
        public mainpage ()
        {
            InitializeComponent();
        }

        private void btnNav_Click ( object sender , RoutedEventArgs e )
        {
            Button btn = sender as Button;
            var uri = btn.Tag.ToString();
            //uri = "pack://application:,,,/Views/KJ/Window22.xaml";
            //uri = "/Views/KJ/UserControl12.xaml";

            this.frmMain.Navigate( new Uri( uri , UriKind.Relative ) );
        }
    }
}
