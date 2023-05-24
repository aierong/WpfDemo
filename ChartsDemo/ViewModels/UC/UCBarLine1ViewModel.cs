﻿using System;
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
        } =
           {
                new ColumnSeries<double> { Values = new double[] { 426, 583, 104 } },
                new LineSeries<double>   { Values = new double[] { 200, 558, 458 }, Fill = null },
            
            };



        public Axis[] XAxes
        {
            get; set;
        } =
        {
            new Axis
            {
                Name = "Salesman/woman",
                Labels = new string[] { "王", "赵", "张" },
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



        public Axis[] YAxes
        {
            get; set;
        } =
        {
            new Axis
            {
                Name = "Sales amount",
                NamePadding = new LiveChartsCore.Drawing.Padding(0, 15),
                //Labeler = Labelers.Currency,
                //LabelsPaint = new SolidColorPaint
                //{
                //    Color = SKColors.Blue,
                //    //FontFamily = "Times New Roman",
                //    SKFontStyle = new SKFontStyle(SKFontStyleWeight.ExtraBold, SKFontStyleWidth.Normal, SKFontStyleSlant.Italic)
                //},
            }
        };



    }
}
