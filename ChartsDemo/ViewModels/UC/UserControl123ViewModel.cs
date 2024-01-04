using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Prism.Mvvm;
using SkiaSharp;



namespace ChartsDemo.ViewModels.UC
{
    public class UserControl123ViewModel : BindableBase
    {
        /// <summary>
        /// 设置标题
        /// </summary>
        public LabelVisual Title
        {
            get; set;
        } = new LabelVisual
        {
            Text = "My 标题(x轴是文字)" ,

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
                    Values = new double[] { 12, 1, 3, 5, 9, 24  },

                    Fill = null,

                    //距离x,y轴的距离
                    //下面这样就没有距离了
                    DataPadding =  new LiveChartsCore.Drawing.LvcPoint (0,0.5),

                    //给线,或者柱子指定颜色和粗细
                    //如果是饼图，请使用：Fill
                    Stroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 1 },
                    //Fill = new SolidColorPaint( SKColors.Red ) ,

                    
                    //中间节点,圆圈的颜色和粗细
                    GeometryStroke = new SolidColorPaint(SKColors.Gray) { StrokeThickness =1 },
                    //中间节点,圆圈的填充颜色
                    GeometryFill = new SolidColorPaint(SKColors.Green),


                    //中间节点,显示值
                    DataLabelsSize = 20,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Blue),
                    DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                    DataLabelsFormatter = (point) => point.PrimaryValue.ToString("N0"),


                    //线的平滑度
                    LineSmoothness = 0
                }
        };



        public Axis[] XAxes
        {
            get; set;
        } =
        {
            new Axis
            {
                //定义x轴值
                Labels = new string[] { "08-10", "10-12", "12-14", "14-16", "16-18", "18-20", },

                
               

                //标签字体大小
                //TextSize =8,

                //标签旋转角度 
                LabelsRotation = 5,

                //标签的内边距
                Padding = new LiveChartsCore.Drawing.Padding(0, 0),


                LabelsPaint = new SolidColorPaint
                {
                    //x轴文本颜色
                    Color = SKColors.Orange,

                    SKTypeface = SKFontManager.Default.MatchCharacter('汉') // 汉语 
                    // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                    // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                    // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                                 
                }
            }
        };



        public Axis[] YAxes
        {
            get; set;
        } =   {
            new Axis
            {
                //名字
                //Name = "Sales amount",

                //名字，显示边距
                //NamePadding = new LiveChartsCore.Drawing.Padding(0, 12),

                //Padding = new LiveChartsCore.Drawing.Padding(0, 0),

                //不显示y轴
                //IsVisible = false,

                 

                //显示分割线
                //ShowSeparatorLines = false,

                //格式化y轴文本,这个好像只对y轴有效
                Labeler = (value) => value.ToString( ) +"qq",

                LabelsPaint = new SolidColorPaint
                {
                    //轴文本颜色
                    Color = SKColors.Orange,

                }

            }
        };



        public UserControl123ViewModel ()
        {
        }


        public LiveChartsCore.Measure.Margin Margin { get; set; } 
            = new LiveChartsCore.Measure.Margin( 30 );

    }
}
