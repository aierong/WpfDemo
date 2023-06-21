using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore.SkiaSharpView.Painting;
using Prism.Mvvm;
using SkiaSharp;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.Collections.ObjectModel;
using LiveChartsCore.Defaults;
using LiveChartsCore.Drawing;
using Prism.Commands;

namespace ChartsDemo.ViewModels.UC
{
    public class UCBarRow1DongTaiViewModel : BindableBase
    {

        private Axis[] _xAxes = { new Axis { SeparatorsPaint = new SolidColorPaint( new SKColor( 220 , 220 , 220 ) ) } };

        public Axis[] XAxes
        {
            get
            {
                return _xAxes;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _xAxes , value );
            }
        }



        private Axis[] _yAxes = { new Axis { IsVisible = false } };


        public Axis[] YAxes
        {
            get
            {
                return _yAxes;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _yAxes , value );
            }
        }



        ISeries[] _Series = new ISeries[]
        {
            new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(11.1) },
                Name = "s1",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            },
            new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(9.3) },
                Name = "s2",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            },
            new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(7.1) },
                Name = "s3",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            },
             new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(6.1) },
                Name = "s4",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            },
              new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(5.1) },
                Name = "s5",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            }
        };



        public ISeries[] Series
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



        public UCBarRow1DongTaiViewModel ()
        {

        }


        private DelegateCommand _BButtonClickCommand;
        public DelegateCommand BButtonClickCommand => _BButtonClickCommand ?? ( _BButtonClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            var randomValue = _random.Next( 1 , 20 );

            foreach ( var item in Series )
            {
                if ( item.Values is null )
                    continue;

                var i = ( ( ObservableValue[] ) item.Values )[0];
                i.Value += _random.Next( 1 , 20 );
            }

            Series = Series.OrderByDescending( item => ( ( ObservableValue[] ) item.Values )[0].Value ).ToArray();

        } ) );
    }
}
