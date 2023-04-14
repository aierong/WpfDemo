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
using Prism.Regions;

namespace PrismDemo.RegionDemo.View
{
    /// <summary>
    /// RegionDemo1.xaml 的互動邏輯
    /// </summary>
    public partial class RegionDemo1 : Window
    {
        public RegionDemo1 ()
        {
            InitializeComponent();

            //代码指定区域名字
            //RegionManager.SetRegionName( cct , "ContentRegion" );


        }
    }
}
