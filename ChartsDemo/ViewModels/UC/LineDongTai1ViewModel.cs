﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

//参考：https://lvcharts.com/docs/wpf/2.0.0-beta.710/samples.lines.autoupdate

namespace ChartsDemo.ViewModels.UC
{
    public class LineDongTai1ViewModel : BindableBase, INavigationAware
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

        public LineDongTai1ViewModel ()
        {
            _observableValues = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2),

                new ObservableValue(4),
                new ObservableValue(2),
                new ObservableValue(3),
                new ObservableValue(4),
                new ObservableValue(3)


                //new(5), //  (C# 9 可以这样写)
            };

            Series = new ObservableCollection<ISeries>
            {
                new LineSeries<ObservableValue>
                {
                    Values =_observableValues,
                    Fill = null
                }
            };


        }

        private readonly ObservableCollection<ObservableValue> _observableValues;

        private DelegateCommand _ADDButtonClickCommand;
        public DelegateCommand ADDButtonClickCommand => _ADDButtonClickCommand ?? ( _ADDButtonClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            var randomValue = _random.Next( 1 , 20 );

            _observableValues.Add( new ObservableValue( randomValue ) );
        } ) );

        private DelegateCommand _DELETEButtonClickCommand;
        public DelegateCommand DELETEButtonClickCommand => _DELETEButtonClickCommand ?? ( _DELETEButtonClickCommand = new DelegateCommand( () =>
        {
            if ( _observableValues.Count > 0 )
            {
                //删除第1个
                _observableValues.RemoveAt( 0 );

                return;
            }

        } ) );


        private DelegateCommand _UpdateButtonClickCommand;
        public DelegateCommand UpdateButtonClickCommand => _UpdateButtonClickCommand ?? ( _UpdateButtonClickCommand = new DelegateCommand( () =>
        {
            if ( _observableValues.Count > 0 )
            {
                Random _random = new Random();
                var randomValue = _random.Next( 1 , 20 );

                // 最后一个修改了
                var lastInstance = _observableValues[_observableValues.Count - 1];

                // 
                lastInstance.Value = randomValue;

                return;
            }

        } ) );



        //AddSeries
        private DelegateCommand _AddSeriesButtonClickCommand;
        public DelegateCommand AddSeriesButtonClickCommand => _AddSeriesButtonClickCommand ?? ( _AddSeriesButtonClickCommand = new DelegateCommand( () =>
        {
            if ( Series.Count == 5 )
                return;

            Random _random = new Random();

            Series.Add(
            new LineSeries<int>
            {
                Values = new List<int>
                {
                    _random.Next(0, 10),
                    _random.Next(0, 20),
                    _random.Next(0, 30)
                }
            } );
        } ) );


        //RemoveSeries
        private DelegateCommand _RemoveSeriesButtonClickCommand;
        public DelegateCommand RemoveSeriesButtonClickCommand => _RemoveSeriesButtonClickCommand ?? ( _RemoveSeriesButtonClickCommand = new DelegateCommand( () =>
        {

            if ( Series.Count == 1 )
                return;

            Series.RemoveAt( Series.Count - 1 );

        } ) );



        private DelegateCommand _ResetButtonClickCommand;
        public DelegateCommand ResetButtonClickCommand => _ResetButtonClickCommand ?? ( _ResetButtonClickCommand = new DelegateCommand( () =>
        {
            //this.Series[0].Values.
            _observableValues.Clear();

            Random _random = new Random();

            _observableValues.Add( new ObservableValue( _random.Next( 1 , 20 ) ) );
            _observableValues.Add( new ObservableValue( _random.Next( 1 , 5 ) ) );
            _observableValues.Add( new ObservableValue( _random.Next( 1 , 10 ) ) );
        } ) );














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
