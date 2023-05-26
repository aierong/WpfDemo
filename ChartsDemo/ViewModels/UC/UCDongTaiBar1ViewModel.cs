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
    public  class UCDongTaiBar1ViewModel : BindableBase, INavigationAware
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


        void createdata (int counts)
        {
            for ( int i = 1 ; i <= counts ; i++ )
            {

            }
        }



        private DelegateCommand _ResetButtonClickCommand;
        public DelegateCommand ResetButtonClickCommand => _ResetButtonClickCommand ?? ( _ResetButtonClickCommand = new DelegateCommand( () =>
        {
            //this.Series[0].Values.
            _observableValues.Clear();

            Random _random = new Random();

            _observableValues.Add( new ObservableValue( _random.Next( 1 , 20 ) ) );
            _observableValues.Add( new ObservableValue( _random.Next( 1 , 5 ) ) );
            _observableValues.Add( new ObservableValue( _random.Next( 8 , 10 ) ) );
            _observableValues.Add( new ObservableValue( _random.Next( 8 , 10 ) ) );
            _observableValues.Add( new ObservableValue( _random.Next( 8 , 10 ) ) );

            XAxess.Clear();
            XAxess.Add( new Axis
            {
                Labels = new string[] { "组1" , "组2" , "组3" , "组4" , "组5" } ,
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

        } ) );

        ObservableCollection<Axis> _XAxess=new ObservableCollection<Axis>() {
        {
            new Axis
            {
                Labels = new string[] { "组1" , "组2" , "组3" },
                //旋转角度
                LabelsRotation = 0,
                SeparatorsPaint = new SolidColorPaint(new SKColor(200, 200, 200)),
                SeparatorsAtCenter = false,
                TicksPaint = new SolidColorPaint(new SKColor(35, 35, 35)),
                TicksAtCenter = true,
                LabelsPaint = new SolidColorPaint
                {
                    Color = SKColors.Black,

                    SKTypeface = SKFontManager.Default.MatchCharacter('汉') // 汉语 
                    // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                    // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                    // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                }
            }
        }};

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


        //public Axis[] XAxes
        //{
        //    get; set;
        //} =
        //{
        //    new Axis
        //    {
        //        Labels = new string[] { "组1" , "组2" , "组3" },
        //        //旋转角度
        //        LabelsRotation = 0,
        //        SeparatorsPaint = new SolidColorPaint(new SKColor(200, 200, 200)),
        //        SeparatorsAtCenter = false,
        //        TicksPaint = new SolidColorPaint(new SKColor(35, 35, 35)),
        //        TicksAtCenter = true,
        //        LabelsPaint = new SolidColorPaint
        //        {
        //            Color = SKColors.Black,

        //            SKTypeface = SKFontManager.Default.MatchCharacter('汉') // 汉语 
        //            // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
        //            // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
        //            // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
        //        }
        //    }
        //};







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
