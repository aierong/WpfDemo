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
using WpfApp.Views.TeXiao.LedClock.demo2.viewmodel;

namespace WpfApp.Views.TeXiao.LedClock.demo2.view
{
    /// <summary>
    /// Clockled.xaml 的互動邏輯
    /// </summary>
    public partial class Clockled : Window
    {
        public Clockled ()
        {
            InitializeComponent();



            this.DataContext = new ClockledVM();
        }
    }
}
