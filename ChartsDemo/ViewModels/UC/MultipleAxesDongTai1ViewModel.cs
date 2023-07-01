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
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class MultipleAxesDongTai1ViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<ObservableValue> _dt_observableValues1 = new ObservableCollection<ObservableValue>()
        {
        };

        private ObservableCollection<ObservableValue> _dt_observableValues2 = new ObservableCollection<ObservableValue>()
        {
        };


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

        private ObservableCollection<string> _observableValues_x_val = new ObservableCollection<string>()
        {
        };

        ObservableCollection<Axis> _XAxess = new ObservableCollection<Axis>() { };

        public ObservableCollection<Axis> XAxess
        {
            get
            {
                return _XAxess;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _XAxess , value );
            }
        }

        public MultipleAxesDongTai1ViewModel ()
        {

            _dt_observableValues1 = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2),

                new ObservableValue(4),

                new ObservableValue(13),

            };

            _dt_observableValues2 = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(3),

                new ObservableValue(5),

                new ObservableValue(9),

            };

            Series = new ObservableCollection<ISeries>()
            {
                new ColumnSeries<ObservableValue>
                {
                    //Name = "计划数量",
                    Values =_dt_observableValues1,
                    //指定这个系列柱子颜色，如果不指定，系统自动分配
                    Fill = new SolidColorPaint(SKColors.Red),

                },
                new ColumnSeries<ObservableValue>
                {
                    //Name = "实际数量",
                    Values = _dt_observableValues2,

                    //指定这个系列柱子颜色，如果不指定，系统自动分配
                    Fill = new SolidColorPaint(SKColors.Green  ),
                },
            };


            //数据构建完成,开始x轴
            _observableValues_x_val = new ObservableCollection<string>()
            {
                "王", "赵", "张"
            };

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
