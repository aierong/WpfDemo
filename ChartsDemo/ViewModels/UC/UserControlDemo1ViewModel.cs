using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Prism.Mvvm;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;



namespace ChartsDemo.ViewModels.UC
{
    public class UserControlDemo1ViewModel : BindableBase
    {
        public ISeries[] Series
        {
            get; set;
        } = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] {
                        2, 1, 3, 5, 3, 4, 16
                    },
                    Fill = null,

                    //格式化，Tooltip
                    TooltipLabelFormatter =         (chartPoint) => $"项目{chartPoint.Context.Series.Name}:{chartPoint.PrimaryValue}"
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





    }
}
