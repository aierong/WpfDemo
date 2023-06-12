using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Markup;
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
    public class UCPieDontTai1ViewModel : BindableBase, INavigationAware
    {

        ObservableCollection<ISeries> _Series = new ObservableCollection<ISeries>() { };

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

      

    

    


        void createdata ( int counts )
        {
            Random _random = new Random();
            


            this.Series.Clear();

            for ( int i = 1 ; i <= counts ; i++ )
            {
                var num = _random.Next( 1 , i == 1 ? 2 : 20 );

                this.Series.Add( new PieSeries<double>
                {

                    Values = new List<double>() { num } ,
                    Name = "系列:" + num.ToString() ,
                    //文字朝向
                    DataLabelsRotation = LiveCharts.CotangentAngle ,

                    //DataLabelsPaint = new SolidColorPaint( SKColors.Black ),
                    DataLabelsSize = 15 ,
                    DataLabelsPaint = new SolidColorPaint()
                    {
                        Color = SKColors.Black ,
                        SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )
                    } ,
                    DataLabelsFormatter = point => point.PrimaryValue.ToString( "N2" ) + "系列:" + num.ToString()
                    //MaxOuterRadius = 0.8,
                    //DataPadding =  new LiveChartsCore.Drawing.LvcPoint (0,0),

                    //InnerRadius = 50
                    //Fill= new SolidColorPaint( SKColors.Yellow ),
                    //Stroke = new SolidColorPaint( SKColors.Red ) { StrokeThickness = 4 } ,
                } );
            }


             


          



            return;


        }



        public UCPieDontTai1ViewModel ()
        {
            this.createdata( new Random().Next( 3 , 4 ) );
        }



        private DelegateCommand _RestClickCommand;
        public DelegateCommand RestClickCommand => _RestClickCommand ?? ( _RestClickCommand = new DelegateCommand( () =>
        {

            //饼图的数量变化，name也变化了

            this.createdata( new Random().Next( 3 , 6 ) );
            return;

        } ) );







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
