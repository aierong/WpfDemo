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

namespace ChartsDemo.ViewModels.UC
{
    public class UCBar1ViewModel : BindableBase
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

            //指定颜色，如果不指定，系统自动分配
             Fill = new SolidColorPaint(SKColors.Red),
             //可以指定最大宽度
             //MaxBarWidth = 10
            MaxBarWidth = double.MaxValue,

            GroupPadding = 10
        },
        new ColumnSeries<double>
        {
            Name = "Ana",
            Values = new double[] { 3, 1, 6 },

            Fill = new SolidColorPaint(SKColors.Green  ),

            MaxBarWidth = double.MaxValue,

             GroupPadding = 10
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

        //public SolidColorPaint LedgendBackgroundPaint
        //{
        //    get; set;
        //} =
        //new SolidColorPaint( SKColors.Blue  );


    }
}
