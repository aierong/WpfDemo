using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class UCPieDontTai1ViewModel : BindableBase, INavigationAware
    {

        ObservableCollection<ISeries> _Series;

        public ObservableCollection<ISeries> Series
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



        public UCPieDontTai1ViewModel ()
        {

            Series = new ObservableCollection<ISeries>
            {
                // Use the ObservableValue or ObservablePoint types to let the chart listen for property changes // mark
                // or use any INotifyPropertyChanged implementation // mark
                new PieSeries<ObservableValue> { Values = new[] { new ObservableValue(2) } ,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        DataLabelsSize = 22,
        // for more information about available positions see:
        // https://lvcharts.com/api/2.0.0-beta.710/LiveChartsCore.Measure.PolarLabelsPosition
        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
        DataLabelsFormatter = point => point.PrimaryValue.ToString("N2") + " elements"
                },
                new PieSeries<ObservableValue> { Values = new[] { new ObservableValue(5) } ,  DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        DataLabelsSize = 22,
        // for more information about available positions see:
        // https://lvcharts.com/api/2.0.0-beta.710/LiveChartsCore.Measure.PolarLabelsPosition
        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
        DataLabelsFormatter = point => point.PrimaryValue.ToString("N2") + " elements" },
                new PieSeries<ObservableValue> { Values = new[] { new ObservableValue(3) } , DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        DataLabelsSize = 22,
        // for more information about available positions see:
        // https://lvcharts.com/api/2.0.0-beta.710/LiveChartsCore.Measure.PolarLabelsPosition
        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
        DataLabelsFormatter = point => point.PrimaryValue.ToString("N2") + " elements"},

            };



        }



        private DelegateCommand _RestClickCommand;
        public DelegateCommand RestClickCommand => _RestClickCommand ?? ( _RestClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();

            this.Series.Clear();

            Series.Add(
           new PieSeries<ObservableValue>
           {
               Values = new[] { new ObservableValue( _random.Next( 1 , 10 ) ) } ,
               //Name = "SliceA"
           } );

            Series.Add(
           new PieSeries<ObservableValue>
           {
               Values = new[] { new ObservableValue( _random.Next( 1 , 10 ) ) } ,
               //Name = "SliceB"
           } );

            Series.Add(
           new PieSeries<ObservableValue>
           {
               Values = new[] { new ObservableValue( _random.Next( 1 , 10 ) ) } ,
               //Name = "Slicec"
           } );

            //  Series.Add(
            //new PieSeries<ObservableValue>
            //{
            //    Values = new[] { new ObservableValue( _random.Next( 1 , 10 ) ) } ,
            //    Name = "Sliced"
            //} );


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
