using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using Prism.Commands;
using Prism.Mvvm;

namespace ChartsDemo.ViewModels.UC
{
    public  class UCDongTaiBar1ViewModel : BindableBase
    {

        private readonly ObservableCollection<ObservableValue> _observableValues;

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


        public UCDongTaiBar1ViewModel()
        {
            _observableValues = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2),

                new ObservableValue(4),
                new ObservableValue(2),
                new ObservableValue(3),
            


                //new(5), //  (C# 9 可以这样写)
            };

            Series = new ObservableCollection<ISeries>
            {
                new ColumnSeries<ObservableValue>
                {
                    Values = _observableValues
                }
            };
        }




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




    }
}
