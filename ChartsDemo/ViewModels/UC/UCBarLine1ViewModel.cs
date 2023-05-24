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

namespace ChartsDemo.ViewModels.UC
{
    public class UCBarLine1ViewModel : BindableBase
    {
        public ISeries[] Series
        {
            get; set;
        } =     {
            //多组数据

                new ColumnSeries<double>
                {
                    //Name = "Mary姐姐",
                    Values = new double[] { 2, 5, 4 }
                },


                new LineSeries<double>   { Values = new double[] { 200, 558, 458 }, Fill = null }


        };


        public Axis[] XAxes
        {
            get; set;
        } =
           {
                new Axis
                {
                    //标题
                    Name = "Salesman/woman",
                    //  labels 
                    Labels = new string[] { "Sergio", "Lando弟弟", "Lewis姐姐" },
                    //旋转角度
                    LabelsRotation = 1,
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
