using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class MultipleAxesViewModel : BindableBase, INavigationAware
    {
        public SolidColorPaint LegendTextPaint
        {
            get; set;
        } =
        new SolidColorPaint
        {
            Color = new SKColor( 50 , 50 , 50 ) ,
            SKTypeface = SKTypeface.FromFamilyName( "Courier New" )
        };

        public SolidColorPaint LedgendBackgroundPaint
        {
            get; set;
        } =
            new SolidColorPaint( new SKColor( 240 , 240 , 240 ) );

        private static readonly SKColor s_blue = new SKColor( 25 , 118 , 210 );
        private static readonly SKColor s_red = new SKColor( 229 , 57 , 53 );
        private static readonly SKColor s_yellow = new SKColor( 198 , 167 , 0 );


        public ISeries[] Series
        {
            get; set;
        } = {

            new LineSeries<double>
        {
            LineSmoothness = 1,
            Name = "Tens",
            Values = new double[] { 14, 13, 14, 15, 17 },
            Stroke = new SolidColorPaint(s_blue, 2),
            GeometrySize = 10,
            GeometryStroke = new SolidColorPaint(s_blue, 2),
            Fill = null,
            //这里指定第一组y轴
            ScalesYAt = 0 // it will be scaled at the Axis[0] instance 
        },
        new LineSeries<double>
        {
            Name = "Tens 2",
            Values = new double[] { 13, 2, 13, 10, 12 },
            Stroke = new SolidColorPaint(s_blue, 2),
            GeometrySize = 10,
            GeometryStroke = new SolidColorPaint(s_blue, 2),
            Fill = null,
            //这里指定第一组y轴
            ScalesYAt = 0 // it will be scaled at the Axis[0] instance 
        },
        new LineSeries<double>
        {
            Name = "Hundreds",
            Values = new double[] { 533, 586, 425, 579, 518 },
            Stroke = new SolidColorPaint(s_red, 2),
            GeometrySize = 10,
            GeometryStroke = new SolidColorPaint(s_red, 2),
            Fill = null,
            //这里指定第2组y轴
            ScalesYAt = 1 // it will be scaled at the YAxes[1] instance 
        },
        new LineSeries<double>
        {
            Name = "Thousands",
            Values = new double[] { 5493, 7843, 4368, 9018, 3902 },
            Stroke = new SolidColorPaint(s_yellow, 2),
            GeometrySize = 10,
            GeometryStroke = new SolidColorPaint(s_yellow, 2),
            Fill = null,
            //这里指定第3组y轴
            ScalesYAt = 2  // it will be scaled at the YAxes[2] instance 
        }
    };

        public ICartesianAxis[] YAxes
        {
            get; set;
        } =
        {
        new Axis // the "units" and "tens" series will be scaled on this axis
        {
            Name = "Tens",
            NameTextSize = 14,
            NamePaint = new SolidColorPaint(s_blue),
            NamePadding = new LiveChartsCore.Drawing.Padding(0, 20),
            Padding =  new LiveChartsCore.Drawing.Padding(0, 0, 20, 0),
            TextSize = 12,
            LabelsPaint = new SolidColorPaint(s_blue),
            TicksPaint = new SolidColorPaint(s_blue),
            SubticksPaint = new SolidColorPaint(s_blue),
            DrawTicksPath = true
        },
        new Axis // the "hundreds" series will be scaled on this axis
        {
            Name = "Hundreds",
            NameTextSize = 14,
            NamePaint = new SolidColorPaint(s_red),
            NamePadding = new LiveChartsCore.Drawing.Padding(0, 20),
            Padding =  new LiveChartsCore.Drawing.Padding(20, 0, 0, 0),
            TextSize = 12,
            LabelsPaint = new SolidColorPaint(s_red),
            TicksPaint = new SolidColorPaint(s_red),
            SubticksPaint = new SolidColorPaint(s_red),
            DrawTicksPath = true,
            //不显示数据分割线
            ShowSeparatorLines = false,
            //y轴显示在右边
            Position = LiveChartsCore.Measure.AxisPosition.End
        },
        new Axis // the "thousands" series will be scaled on this axis
        {
            Name = "Thousands",
            NameTextSize = 14,
            NamePadding = new LiveChartsCore.Drawing.Padding(0, 20),
            Padding =  new LiveChartsCore.Drawing.Padding(20, 0, 0, 0),
            NamePaint = new SolidColorPaint(s_yellow),
            TextSize = 12,
            LabelsPaint = new SolidColorPaint(s_yellow),
            TicksPaint = new SolidColorPaint(s_yellow),
            SubticksPaint = new SolidColorPaint(s_yellow),
            DrawTicksPath = true,
            //不显示数据分割线
            ShowSeparatorLines = false,
            //y轴显示在右边
            Position = LiveChartsCore.Measure.AxisPosition.End
        }
        };
































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
