using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class MultipleAxesDongTai1ViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<ObservableValue> _observableValues1 = new ObservableCollection<ObservableValue>()
        {
        };

        private ObservableCollection<ObservableValue> _observableValues2 = new ObservableCollection<ObservableValue>()
        {
        };

        private ObservableCollection<ObservableValue> _observableValues3 = new ObservableCollection<ObservableValue>()
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

        ObservableCollection<Axis> _XAxes = new ObservableCollection<Axis>() { };

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


        ObservableCollection<Axis> _YAxes = new ObservableCollection<Axis>() { };

        public ObservableCollection<Axis> YAxes
        {
            get
            {
                return _YAxes;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _YAxes , value );
            }
        }

        public MultipleAxesDongTai1ViewModel ()
        {

            _observableValues1 = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2000),

                new ObservableValue(1400),

                new ObservableValue(1300),

            };

            _observableValues2 = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(2300),

                new ObservableValue(1500),

                new ObservableValue(900),

            };

            _observableValues3 = new ObservableCollection<ObservableValue>
            {
                new ObservableValue(0.3),

                new ObservableValue(0.9),

                new ObservableValue(0.88),

            };

            Series = new ObservableCollection<ISeries>()
            {
                new ColumnSeries<ObservableValue>
                {
                    //Name = "计划数量",
                    Values =_observableValues1,
                    //指定这个系列柱子颜色，如果不指定，系统自动分配
                    Fill = new SolidColorPaint(SKColors.Red),

                    // ,显示值
                    DataLabelsPaint = new SolidColorPaint(  SKColors.Red),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Top,


                    //这里指定第一组y轴
                    ScalesYAt = 0
                },
                new ColumnSeries<ObservableValue>
                {
                    //Name = "实际数量",
                    Values = _observableValues2,

                    //指定这个系列柱子颜色，如果不指定，系统自动分配
                    Fill = new SolidColorPaint(SKColors.Green  ),

                    // ,显示值
                    DataLabelsPaint = new SolidColorPaint(  SKColors.Green),
            DataLabelsSize = 14,
            DataLabelsPosition = DataLabelsPosition.Top,

                    //这里指定第一组y轴
                    ScalesYAt = 0
                },
                new LineSeries<ObservableValue>
                {
                    Values =_observableValues3,
                    Fill = null,

                    //中间节点,显示值
                    DataLabelsSize = 20,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Blue),
                    DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,

                    Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 1 },
                    //这里指定第2组y轴
                    ScalesYAt = 1
                }
            };


            //数据构建完成,开始x轴
            _observableValues_x_val = new ObservableCollection<string>()
            {
                "王", "赵", "张"
            };


            XAxes = new ObservableCollection<Axis>()
            {
                new Axis
                {

                    Labels = _observableValues_x_val ,
                    

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
            };

            //开始y轴
            YAxes = new ObservableCollection<Axis>()
            {
                new Axis
                {
                    Name = "数量",
                    NamePadding = new LiveChartsCore.Drawing.Padding(0, 15),
                    NamePaint=  new SolidColorPaint
                    {
                        Color = SKColors.Black,

                        SKTypeface = SKFontManager.Default.MatchCharacter('汉') // 汉语 
                        // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                        // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                        // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                    },
                    MinLimit=0



                },
                new Axis
                {
                    Name = "不良率",
                    NamePadding = new LiveChartsCore.Drawing.Padding(0, 15),
                    NamePaint=  new SolidColorPaint
                    {
                        Color = SKColors.Blue,

                        SKTypeface = SKFontManager.Default.MatchCharacter('汉') // 汉语 
                        // SKTypeface = SKFontManager.Default.MatchCharacter('أ'), // Arab
                        // SKTypeface = SKFontManager.Default.MatchCharacter('あ'), // Japanese
                        // SKTypeface = SKFontManager.Default.MatchCharacter('Ж'), // Russian
                    },
                    LabelsPaint = new SolidColorPaint(SKColors.Blue),
                    MinLimit=0,
                    //ShowSeparatorLines = true,
                    //SeparatorsPaint =new SolidColorPaint
                    //{
                    //    Color = SKColors.Blue,
                    //},
                    ShowSeparatorLines = false,
                    Position = LiveChartsCore.Measure.AxisPosition.End
                },

            };

        }







        private DelegateCommand _UpdateButtonClickCommand;
        public DelegateCommand UpdateButtonClickCommand => _UpdateButtonClickCommand ?? ( _UpdateButtonClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            var fors = _random.Next( 2 , 6 );

            _observableValues1.Clear();
            _observableValues2.Clear();
            _observableValues3.Clear();
            _observableValues_x_val.Clear();
            for ( int i = 1 ; i <= fors ; i++ )
            {
                 
                var num2 = _random.Next( 1 , 9 )/10.0;

                _observableValues1.Add( new ObservableValue( _random.Next( 2000 , 2500 ) ) );
                _observableValues2.Add( new ObservableValue( _random.Next( 1600 , 2500 ) ) );
                _observableValues3.Add( new ObservableValue( num2 ) );

                _observableValues_x_val.Add(  num2.ToString () + "xval" );
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
