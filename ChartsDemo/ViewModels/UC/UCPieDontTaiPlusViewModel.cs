using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SkiaSharp;

namespace ChartsDemo.ViewModels.UC
{
    public class UCPieDontTaiPlusViewModel : BindableBase, INavigationAware
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

        public UCPieDontTaiPlusViewModel ()
        {
            this.createdata( new Random().Next( 2 , 5 ) );
        }



        void createdata ( int counts )
        {
            //特别说明：counts 最大是4

            Random _random = new Random();

            this.Series.Clear();



            for ( int i = 1 ; i <= counts ; i++ )
            {
                if ( i == 1 )
                {
                    var num = _random.Next( 1 , 20 );

                    this.Series.Add( new PieSeries<double>
                    {

                        Values = new List<double>() { num } ,
                        //Name = "系列:" + num.ToString() ,
                        Fill = new SolidColorPaint( SKColors.Red ) ,

                        DataLabelsPaint = new SolidColorPaint( SKColors.Black ) ,
                        DataLabelsSize = 15 ,

                        DataLabelsFormatter = point => point.PrimaryValue.ToString()

                    } );
                }

                if ( i == 2 )
                {
                    var num = _random.Next( 1 , 20 );

                    this.Series.Add( new PieSeries<double>
                    {

                        Values = new List<double>() { num } ,
                        //Name = "系列:" + num.ToString() ,
                        Fill = new SolidColorPaint( SKColors.Yellow ) ,

                        DataLabelsPaint = new SolidColorPaint( SKColors.Black ) ,
                        DataLabelsSize = 15 ,

                        DataLabelsFormatter = point => point.PrimaryValue.ToString()

                    } );
                }

                if ( i == 3 )
                {
                    var num = _random.Next( 1 , 20 );

                    this.Series.Add( new PieSeries<double>
                    {

                        Values = new List<double>() { num } ,
                        //Name = "系列:" + num.ToString() ,
                        Fill = new SolidColorPaint( SKColors.Blue ) ,

                        DataLabelsPaint = new SolidColorPaint( SKColors.Black ) ,
                        DataLabelsSize = 15 ,

                        DataLabelsFormatter = point => point.PrimaryValue.ToString()

                    } );
                }

                if ( i == 4 )
                {
                    var num = _random.Next( 1 , 20 );

                    this.Series.Add( new PieSeries<double>
                    {

                        Values = new List<double>() { num } ,
                        //Name = "系列:" + num.ToString() ,
                        Fill = new SolidColorPaint( SKColors.Green ) ,

                        DataLabelsPaint = new SolidColorPaint( SKColors.Black ) ,
                        DataLabelsSize = 15 ,

                        DataLabelsFormatter = point => point.PrimaryValue.ToString()

                    } );
                }
            }








            return;


        }



        private DelegateCommand _RestClickCommand;
        public DelegateCommand RestClickCommand => _RestClickCommand ?? ( _RestClickCommand = new DelegateCommand( () =>
        {

            //饼图的数量变化，name也变化了

            this.createdata( new Random().Next( 3 , 5 ) );
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
