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
using Prism.Regions;

namespace ChartsDemo.ViewModels.UC
{
    public class UCBarRow1DongTaiViewModel : BindableBase, INavigationAware
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



        List<ISeries> _Series = new List<ISeries>
        {
            new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(11) },
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
                Values = new[] { new ObservableValue(9) },
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
                Values = new[] { new ObservableValue(7) },
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
                Values = new[] { new ObservableValue(3) },
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
                Values = new[] { new ObservableValue(2) },
                Name = "s5",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            },
               new RowSeries<ObservableValue>()
            {
                Values = new[] { new ObservableValue(0) },
                Name = "s6",
                Stroke = null,
                MaxBarWidth = 25,
                DataLabelsPaint = new SolidColorPaint(new SKColor(245, 245, 245)),
                DataLabelsPosition = DataLabelsPosition.End,
                DataLabelsTranslate = new LvcPoint(-1, 0),
                DataLabelsFormatter = point => $"{point.Context.Series.Name} {point.PrimaryValue}"
            }
        };



        public List<ISeries> Series
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







        /* Racing Bars 赛跑模式柱形图
        大体思路：
        图表中系列数量是固定的,并且系列名也是固定的，每次变化就是值在变化

        初始化时先按值从大到小排列下来
        变化事件：就改变值，并且重新排序
        */

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
                i.Value += _random.Next( 0 , 20 );
            }

            

            //排序一下
            Series = Series.OrderByDescending( item => ( ( ObservableValue[] ) item.Values )[0].Value ).ToList ();

        } ) );








        public UCBarRow1DongTaiViewModel ()
        {

        }





        /*
INavigationAware接口3个方法:

OnNavigatedFrom：导航之前触发(导航离开当前页时触发),一般用于保存该页面的数据
OnNavigatedTo：导航后目的页面触发，一般用于初始化或者接受上页面的传递参数
IsNavigationTarget：True则重用该View实例，Flase则每一次导航到该页面都会实例化一次
*/

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
