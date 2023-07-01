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
                    }
                   


                }
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
