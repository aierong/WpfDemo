using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class Pie1ViewModel : BindableBase, INavigationAware
    {
        public IEnumerable<ISeries> Series
        {
            get; set;
        } = new ISeries[]
            {
                 new PieSeries<double> { Values = new double[] { 2 }, Name = "Slice 1"   },
                 new PieSeries<double> { Values = new double[] { 4 } , Name = "Slice 2"   },
                 new PieSeries<double> { Values = new double[] { 1 } , Name = "Slice 3"   },
                 new PieSeries<double> { Values = new double[] { 13 } , Name = "类型4"   },
                 new PieSeries<double> { Values = new double[] { 3 } , Name = "类型5"  }



                 //Pushout是配置推出尺寸
                 //new PieSeries<double> { Values = new double[] { 2 }, Name = "Slice 1" ,Pushout = 1 },
                 //new PieSeries<double> { Values = new double[] { 4 } , Name = "Slice 2" ,Pushout = 1 },
                 //new PieSeries<double> { Values = new double[] { 1 } , Name = "Slice 3" ,Pushout = 1 },
                 //new PieSeries<double> { Values = new double[] { 13 } , Name = "类型4" ,Pushout = 2 },
                 //new PieSeries<double> { Values = new double[] { 3 } , Name = "类型5" ,Pushout = 1 }
            };



        public LabelVisual Title
        {
            get; set;
        } = new LabelVisual
        {
            Text = "My的饼图" ,
            TextSize = 25 ,
            Padding = new LiveChartsCore.Drawing.Padding( 15 ) ,
            //Paint = new SolidColorPaint( SKColors.DarkSlateGray )
            Paint = new SolidColorPaint()
            {
                Color = SKColors.DarkSlateGray ,
                SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )
            }
        };



        public SolidColorPaint TooltipTextPaint
        {
            get; set;
        } = new SolidColorPaint
        {
            Color = new SKColor( 242 , 0 , 0 ) ,
            SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )
        };

        public SolidColorPaint LegendTextPaint
        {
            get; set;
        } =
        new SolidColorPaint
        {
            Color = SKColors.Black ,
            SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )
        };



        public Pie1ViewModel ()
        {
        }





        /*
INavigationAware接口3个方法:

OnNavigatedFrom：导航之前触发(导航离开当前页时触发),一般用于保存该页面的数据
OnNavigatedTo：导航后目的页面触发，一般用于初始化或者接受上页面的传递参数
IsNavigationTarget：True则重用该View实例，Flase则每一次导航到该页面都会实例化一次
*/

        public void OnNavigatedTo ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
        }

        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
            //IsNavigationTarget：True则重用该View实例，Flase则每一次导航到该页面都会实例化一次
            return false;
        }

        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
        }
    }
}
