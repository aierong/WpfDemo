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
    public class UserControlLineDuoViewModel : BindableBase
    {
        public ISeries[] Series
        {
            get; set;
        } =     {

            //可以是多组数据

            new LineSeries<double>
            {
                Values = new double[] { 5, 0, 5, 0, 5, 0 },
                Fill = null,
                GeometrySize = 0,
            
                // LineSmoothness
                LineSmoothness = 0
            },
            new LineSeries<double>
            {
                Values = new double[] { 7, 2, 7, 2, 7, 2 },
                Fill = null,
                GeometrySize = 0,
                LineSmoothness = 1
            }
        };



        /// <summary>
        /// 设置标题
        /// </summary>
        public LabelVisual Title
        {
            get; set;
        } = new LabelVisual
        {
            Text = "My chart 多组数据" ,

 
 
            Paint = new SolidColorPaint()
            {
                Color = SKColors.Blue ,
                SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )
            }
        };


    }
}
