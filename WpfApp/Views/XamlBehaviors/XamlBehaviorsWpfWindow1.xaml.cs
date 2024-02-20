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

namespace WpfApp.Views.XamlBehaviors
{
    /// <summary>
    /// XamlBehaviorsWpfWindow1.xaml 的互動邏輯
    /// </summary>
    public partial class XamlBehaviorsWpfWindow1 : Window
    {
        public XamlBehaviorsWpfWindow1 ()
        {
            InitializeComponent();

            this.DataContext = new XamlBehaviorsWpfWindow1VM();
        }

        //private void Button_MouseRightButtonDown ( object sender , MouseButtonEventArgs e )
        //{

        //}



        //private void TextBlock_MouseRightButtonDown ( object sender , MouseButtonEventArgs e )
        //{

        //}
    }
}
