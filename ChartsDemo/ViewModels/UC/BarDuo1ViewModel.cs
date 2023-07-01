using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Prism.Mvvm;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Windows.Ink;
using Prism.Regions;

namespace ChartsDemo.ViewModels.UC
{
    public class BarDuo1ViewModel : BindableBase, INavigationAware
    {
        public ISeries[] Series
        {
            get; set;
        } =     {
        //多组数据

        new ColumnSeries<double>
        {
            Name = "Mary姐姐",
            Values = new double[] { 2, 5, 4 },

            //指定这个系列柱子颜色，如果不指定，系统自动分配
             Fill = new SolidColorPaint(SKColors.Red),

             //可以指定最大宽度
             //MaxBarWidth = 10
            MaxBarWidth = double.MaxValue,

            
            //每个柱子之间的间距，旧版本用GroupPadding
             Padding = 30
            //GroupPadding = 30,
        },
        new ColumnSeries<double>
        {
            Name = "Ana",
            Values = new double[] { 3, 1, 6 },

            //指定这个系列柱子颜色，如果不指定，系统自动分配
            Fill = new SolidColorPaint(SKColors.Green  ),

            MaxBarWidth = double.MaxValue,

            
             Padding = 30
            // GroupPadding = 30,
        }
    };


        public Axis[] XAxes
        {
            get; set;
        } =
        {
            new Axis
            {
                Labels = new string[] { "组1" , "组2" , "Category3" },
                //旋转角度
                LabelsRotation = 0,
                SeparatorsPaint = new SolidColorPaint(new SKColor(200, 200, 200)),
                SeparatorsAtCenter = false,
                TicksPaint = new SolidColorPaint(new SKColor(35, 35, 35)),
                TicksAtCenter = true,
                LabelsPaint = new SolidColorPaint
                {
                    Color = SKColors.Black,

                    SKTypeface = SKFontManager.Default.MatchCharacter('汉') // 汉语 
                    // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                    // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                    // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                }
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
