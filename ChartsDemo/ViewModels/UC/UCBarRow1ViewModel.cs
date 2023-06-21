using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using Prism.Mvvm;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class UCBarRow1ViewModel : BindableBase
    {
        public ISeries[] Series
        {
            get; set;
        } ={
        new RowSeries<int>
        {
            Values = new List<int> { 8, -3, 4 },
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.End
        },
        new RowSeries<int>
        {
            Values = new List<int> { 4, -6, 5 },
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(new SKColor(250, 250, 250)),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Middle
        },
        new RowSeries<int>
        {
            Values = new List<int> { 6, -9, 3 },
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Start
        }
    };



        public UCBarRow1ViewModel ()
        {

        }

    }
}
