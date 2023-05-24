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
            Text = "My chart 标题" ,

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
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
        };


    };
}

