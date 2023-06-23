using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Reflection;
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
    public class BarDongTai1ViewModel : BindableBase, INavigationAware
    {

        private readonly ObservableCollection<ObservableValue> _observableValues = new ObservableCollection<ObservableValue>() { };

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


        public BarDongTai1ViewModel ()
        {
            Series = new ObservableCollection<ISeries>
            {
                new ColumnSeries<ObservableValue>
                {
                    Values = _observableValues
                }
            };

            this.createdata( 3 );



            init();
        }



        void createdata ( int counts )
        {
            _observableValues.Clear();

            Random _random = new Random();
            List<string> listname = new List<string>() { };

            for ( int i = 1 ; i <= counts ; i++ )
            {
                _observableValues.Add( new ObservableValue( _random.Next( 1 , 20 ) ) );
                listname.Add( "组" + i.ToString() );
            }

            XAxess.Clear();
            XAxess.Add( new Axis
            {
                //Labels = new string[] { "组1" , "组2" , "组3" , "组4" , "组5" } ,
                Labels = listname ,
                //旋转角度
                LabelsRotation = 0 ,
                SeparatorsPaint = new SolidColorPaint( new SKColor( 200 , 200 , 200 ) ) ,
                SeparatorsAtCenter = false ,
                TicksPaint = new SolidColorPaint( new SKColor( 35 , 35 , 35 ) ) ,
                TicksAtCenter = true ,
                LabelsPaint = new SolidColorPaint
                {
                    Color = SKColors.Black ,

                    SKTypeface = SKFontManager.Default.MatchCharacter( '汉' ) // 汉语 
                    // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                    // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                    // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                }
            } );
        }



        private DelegateCommand _ResetButtonClickCommand;
        public DelegateCommand ResetButtonClickCommand => _ResetButtonClickCommand ?? ( _ResetButtonClickCommand = new DelegateCommand( () =>
        {

            this.createdata( new Random().Next( 3 , 7 ) );
            return;


        } ) );































        void init ()
        {
            _dt_observableValues = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2),

                new ObservableValue(4),

                new ObservableValue(13),
                new ObservableValue(23),

                //new(5), //  (C# 9 可以这样写)
            };


            dtSeries = new ObservableCollection<ISeries>()
            {
                new ColumnSeries<ObservableValue>
                {
                    Values =_dt_observableValues,

                }
            };

            _dt_observableValues_x_val = new ObservableCollection<string>()
            {
                "王", "赵", "张", "a123"
            };

            dtXAxess = new ObservableCollection<Axis>()
            {
                new Axis
            {

                Labels = _dt_observableValues_x_val ,
                //旋转角度
                LabelsRotation = 0 ,
                SeparatorsPaint = new SolidColorPaint( new SKColor( 200 , 200 , 200 ) ) ,
                SeparatorsAtCenter = false ,
                TicksPaint = new SolidColorPaint( new SKColor( 35 , 35 , 35 ) ) ,
                TicksAtCenter = true ,
                LabelsPaint = new SolidColorPaint
                {
                    Color = SKColors.Black ,

                    SKTypeface = SKFontManager.Default.MatchCharacter( '汉' ) // 汉语 
                    // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                    // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                    // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                }
            }
            };
        }



        private DelegateCommand _ResetButton222ClickCommand;
        public DelegateCommand ResetButton222ClickCommand => _ResetButton222ClickCommand ?? ( _ResetButton222ClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            var fors = _random.Next( 2 , 8 );

            _dt_observableValues.Clear();
            _dt_observableValues_x_val.Clear();
            for ( int i = 1 ; i <= fors ; i++ )
            {
                var num = _random.Next( 1 , 250 );

                _dt_observableValues.Add( new ObservableValue( num ) );

                _dt_observableValues_x_val.Add( num.ToString() + "系列" );
            }



            //下面是固定个数数量的

            //_dt_observableValues.Clear();
            //_dt_observableValues.Add( new ObservableValue( _random.Next( 1 , 250 ) ) );
            //_dt_observableValues.Add( new ObservableValue( _random.Next( 44 , 55 ) ) );
            //_dt_observableValues.Add( new ObservableValue( _random.Next( 1 , 20 ) ) );
            //_dt_observableValues.Add( new ObservableValue( _random.Next( 1 , 10 ) ) );

            //_dt_observableValues_x_val.Clear();
            //_dt_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_dt_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_dt_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );
            //_dt_observableValues_x_val.Add( _random.Next( 1 , 20 ).ToString() + "x" );


            return;


        } ) );


        private ObservableCollection<string> _dt_observableValues_x_val;


        private ObservableCollection<ObservableValue> _dt_observableValues = new ObservableCollection<ObservableValue>() { };

        ObservableCollection<ISeries> _dtSeries;

        public ObservableCollection<ISeries> dtSeries
        {
            get
            {
                return _dtSeries;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _dtSeries , value );
            }
        }


        ObservableCollection<Axis> _dtXAxess = new ObservableCollection<Axis>() { };

        public ObservableCollection<Axis> dtXAxess
        {
            get
            {
                return _dtXAxess;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _dtXAxess , value );
            }
        }






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
