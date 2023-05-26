using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Prism.Mvvm;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public  class UCBar0ViewModel : BindableBase
    {
        public ISeries[] Series
        {
            get; set;
        } =     {
         
            new ColumnSeries<double>
            {
             
                Values = new double[] { 2, 5, 4 },

                // 参考：https://lvcharts.com/docs/WPF/2.0.0-beta.710/samples.design.linearGradients
                // 设置渐变颜色
                Fill = new LinearGradientPaint(
                    // the gradient will use the following colors array
                    new [] { new SKColor(255, 140, 148), new SKColor(220, 237, 194) },

                    // now with the following points we are specifying the orientation of the gradient
                    // by default the gradient is orientated horizontally
                    // defined by the points: (0, 0.5) and (1, 0.5)
                    // but for this sample we will use a vertical gradient:

                    // to build a vertical gradient we must specify 2 points that will draw a imaginary line
                    // the gradient will interpolate colors lineally as it moves following this imaginary line
                    // the coordinates of these points (X, Y) go from 0 to 1
                    // where 0 is the start of the axis and 1 the end. Then to build our vertical gradient

                    // we must go from the point:
                    // (x0, y0) where x0 could be read as "the middle of the x axis" (0.5) and y0 as "the start of the y axis" (0)
                    new SKPoint(0.5f, 0),

                    // to the point:
                    // (x1, y1) where x1 could be read as "the middle of the x axis" (0.5) and y0 as "the end of the y axis" (1)
                    new SKPoint(0.5f, 1))
            },
       
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




        



    }
}
