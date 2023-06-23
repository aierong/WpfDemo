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
    public class LineDongTai2ViewModel : BindableBase, INavigationAware
    {

        /*
        这个是一个动态线图

        线图中的值每次都会变化，并且x轴的文本也变化,并且还可以线图中的数量也变化
        */

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



        private readonly ObservableCollection<ObservableValue> _observableValues;


        private readonly ObservableCollection<string> _observableValues_x_val;

        public LineDongTai2ViewModel ()
        {
            _observableValues = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2),

                new ObservableValue(4),
                new ObservableValue(2),
                new ObservableValue(3),
                new ObservableValue(13),
                new ObservableValue(23),

                //new(5), //  (C# 9 可以这样写)
            };


            Series = new ObservableCollection<ISeries>()
            {
                new LineSeries<ObservableValue>
                {
                    Values =_observableValues,
                    Fill = null
                }
            };


            _observableValues_x_val = new ObservableCollection<string>()
            {
                "王", "赵", "张", "a123","b","ccc"
            };

            XAxes = new ObservableCollection<Axis>()
            {
                new Axis
                        {

                            Labels = _observableValues_x_val , // new string[] { "王", "赵", "张", "a"  },
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
        }




        ObservableCollection<Axis> _XAxes = new ObservableCollection<Axis>()
        {

        };




        public ObservableCollection<Axis> XAxes
        {
            get
            {
                return _XAxes;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _XAxes , value );
            }
        }


        private DelegateCommand _UpdateButtonClickCommand;
        public DelegateCommand UpdateButtonClickCommand => _UpdateButtonClickCommand ?? ( _UpdateButtonClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            var fors = _random.Next( 2 , 8 );

            _observableValues.Clear();
            //清除x轴的值，随机产生6个x轴的值
            _observableValues_x_val.Clear();
            for ( int i = 1 ; i <= fors ; i++ )
            {
                var num = _random.Next( 1 , 250 );

                _observableValues.Add( new ObservableValue( num ) );

                _observableValues_x_val.Add( num.ToString() + "xval" );
            }

            //_observableValues.Clear();
            //_observableValues.Add( new ObservableValue( _random.Next( 1 , 250 ) ) );
            //_observableValues.Add( new ObservableValue( _random.Next( 44 , 55 ) ) );
            //_observableValues.Add( new ObservableValue( _random.Next( 1 , 20 ) ) );
            //_observableValues.Add( new ObservableValue( _random.Next( 1 , 10 ) ) );
            //_observableValues.Add( new ObservableValue( _random.Next( 0 , 0 ) ) );
            //_observableValues.Add( new ObservableValue( _random.Next( 22 , 44 ) ) );
            //_observableValues.Add( new ObservableValue( _random.Next( 22 , 44 ) ) );


            ////清除x轴的值，随机产生6个x轴的值
            //_observableValues_x_val.Clear();
            //_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "xval" );
            //_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "xval" );
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
