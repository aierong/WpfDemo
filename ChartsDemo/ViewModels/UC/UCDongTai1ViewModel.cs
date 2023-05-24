using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using Prism.Mvvm;



namespace ChartsDemo.ViewModels.UC
{
    public class UCDongTai1ViewModel : BindableBase
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

        public UCDongTai1ViewModel ()
        {
            var _observableValues = new ObservableCollection<ObservableValue>
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

    }
}
