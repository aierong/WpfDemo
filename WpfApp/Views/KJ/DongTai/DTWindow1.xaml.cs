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

namespace WpfApp.Views.KJ.DongTai
{
    /// <summary>
    /// DTWindow1.xaml 的互動邏輯
    /// </summary>
    public partial class DTWindow1 : Window
    {
        public DTWindow1 ()
        {
            InitializeComponent();



            this.DataContext = new DTWindow1VM();
        }
    }
}
