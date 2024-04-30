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

namespace HandyOrgDemo.Views.UserControls
{
    /// <summary>
    /// CoverFlowUserControl1.xaml 的互動邏輯
    /// </summary>
    public partial class CoverFlowUserControl1 : UserControl
    {
        public CoverFlowUserControl1 ()
        {
            InitializeComponent();




        }

        private void UserControl_Loaded ( object sender , RoutedEventArgs e )
        {
            string picpath = Environment.CurrentDirectory + @"\" + @"pics" + @"\";

            //好像不支持mvvm，只有这里加载图片

            this.CoverFlowMain.AddRange( new[]
            {
                new Uri( picpath +"11.jpg" ) ,
                new Uri( picpath +"22.jpg" ) ,
                new Uri( picpath +"33.jpg" ) ,
                new Uri( picpath +"44.jpg" ) ,
            } );
                        
        }
    }
}
