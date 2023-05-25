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
using LiveChartsCore.SkiaSharpView.Painting;
using Prism.Commands;
using Prism.Mvvm;
using SkiaSharp;

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




        public Axis[] XAxes
        {
            get; set;
        } =
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
        };




    }
}
