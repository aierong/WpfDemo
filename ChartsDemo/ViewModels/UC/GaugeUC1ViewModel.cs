using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.VisualElements;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class GaugeUC1ViewModel : BindableBase, INavigationAware
    {


        IEnumerable<ISeries> _Series =
        GaugeGenerator.BuildSolidGauge(
            new GaugeItem(
                30 ,          // the gauge value
                series =>    // the series style
                {
                    series.MaxRadialColumnWidth = 50;
                    series.DataLabelsSize = 50;
                } ) );


        public IEnumerable<ISeries> Series
        {
            get
            {
                return _Series;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _Series , value );
            }
        }
























        private NeedleVisual _Needle;


        public NeedleVisual Needle
        {
            get
            {
                return _Needle;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _Needle , value );
            }
        }

        public IEnumerable<VisualElement<SkiaSharpDrawingContext>> VisualElements
        {
            get; set;
        }

        public IEnumerable<ISeries> Series_GU
        {
            get; set;
        }


        public GaugeUC1ViewModel ()
        {
            var sectionsOuter = 130;
            var sectionsWidth = 20;

            //赋值（初始值）
            Needle = new NeedleVisual
            {
                Value = 45
            };


            Series_GU = GaugeGenerator.BuildAngularGaugeSections(
           new GaugeItem( 60 , s => SetStyle( sectionsOuter , sectionsWidth , s ) ) ,
                new GaugeItem( 30 , s => SetStyle( sectionsOuter , sectionsWidth , s ) ) ,
                new GaugeItem( 10 , s => SetStyle( sectionsOuter , sectionsWidth , s ) ) );


            VisualElements = new VisualElement<SkiaSharpDrawingContext>[]
               {
                    new AngularTicksVisual
                    {
                        LabelsSize = 16,
                        LabelsOuterOffset = 15,
                        OuterOffset = 65,
                        TicksLength = 20 ,

                        //特别提示：下面2个是配置表盘刻度线颜色和字颜色，也可以不配置默认
                        //Stroke =new SolidColorPaint(SKColors.Blue) { StrokeThickness = 1 },
                        //LabelsPaint =new SolidColorPaint(SKColors.Blue)
                    },
                    Needle
               };
        }

        private void SetStyle ( double sectionsOuter , double sectionsWidth , PieSeries<ObservableValue> series )
        {
            series.OuterRadiusOffset = sectionsOuter;
            series.MaxRadialColumnWidth = sectionsWidth;
        }



        private DelegateCommand _LineButtonClickCommand;
        public DelegateCommand LineButtonClickCommand => _LineButtonClickCommand ?? ( _LineButtonClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            //改变这个： Needle.Value  图表就会变
            Needle.Value = _random.Next( 0 , 100 );
        } ) );






        public void OnNavigatedTo ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
        }

        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
            //IsNavigationTarget：True则重用该View实例，Flase则每一次导航到该页面都会实例化一次
            return false;
        }

        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
        }
    }
}
