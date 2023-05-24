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
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class UCPie1ViewModel : BindableBase
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

        public UCPie1ViewModel ()
        {

            
        }
    }
}
