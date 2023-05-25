﻿using System;
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

                    Fill = null,



                    // 参考：https://lvcharts.com/docs/WPF/2.0.0-beta.710/samples.design.linearGradients
                    // 设置渐变颜色
                    Stroke = new LinearGradientPaint(new[]{ new SKColor(45, 64, 89), new SKColor(255, 212, 96)}) { StrokeThickness = 10 },
                    GeometryStroke = new LinearGradientPaint(new[]{ new SKColor(45, 64, 89), new SKColor(255, 212, 96)}) { StrokeThickness = 10 },

                }
        };



        public UserControlLine1ViewModel()
        {
             
        }




    };
}

