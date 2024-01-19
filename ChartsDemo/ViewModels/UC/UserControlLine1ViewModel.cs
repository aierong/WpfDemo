using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Prism.Mvvm;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;
using System.Collections.ObjectModel;
using LiveChartsCore.Drawing;

namespace ChartsDemo.ViewModels.UC
{
    public class UserControlLine1ViewModel : BindableBase
    {

        /// <summary>
        /// 设置标题
        /// </summary>
        public LabelVisual Title
        {
            get; set;
        } = new LabelVisual
        {
            Text = "My chart 标题(x轴是文字)" ,

            TextSize = 25 ,
            Padding = new LiveChartsCore.Drawing.Padding( 15 ) ,
            Paint = new SolidColorPaint()
            {
                Color = SKColors.Blue ,
                SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )
            }
        };



        public ISeries[] Series
        {
            get; set;
        } =     {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 9, 14  },

                    Fill = null,



                    // 参考：https://lvcharts.com/docs/WPF/2.0.0-beta.710/samples.design.linearGradients
                    // 设置渐变颜色
                    Stroke = new LinearGradientPaint(new[]{ new SKColor(45, 64, 89), new SKColor(255, 212, 96)}) { StrokeThickness = 10 },
                    GeometryStroke = new LinearGradientPaint(new[]{ new SKColor(45, 64, 89), new SKColor(255, 212, 96)}) { StrokeThickness = 10 },

                    //配置距离x,y轴的距离 （内边距）
                    //注意：LvcPoint的第1个参数是配置离y轴距离，第2个参数是配置离z轴距离  如果不配置控件默认0.5
                    //下面这样就没有内边距了
                    //DataPadding = new LvcPoint(0,0)

                }
        };



        public Axis[] XAxes
        {
            get; set;
        } =
        {
            new Axis
            {
                //Name = "Salesman/woman",
                Labels = new string[] { "王", "赵", "张", "a", "b", "c" },

                //Padding = new LiveChartsCore.Drawing.Padding(0, 0),

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



        public UserControlLine1ViewModel ()
        {

        }




    };
}

