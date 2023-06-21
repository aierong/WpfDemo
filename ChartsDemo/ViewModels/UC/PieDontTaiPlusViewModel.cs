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
    public class PieDontTaiPlusViewModel : BindableBase, INavigationAware
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


        private string _AoiTxt1 = "";

        /// <summary>
        ///  text 
        /// </summary>
        public string AoiTxt1
        {
            get
            {
                return _AoiTxt1;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _AoiTxt1 , value );

            }
        }

        private bool _IsAoi1 = false;

        /// <summary>
        ///  text 
        /// </summary>
        public bool IsAoi1
        {
            get
            {
                return _IsAoi1;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _IsAoi1 , value );

            }
        }

        private string _AoiTxt2 = "";

        /// <summary>
        ///  text 
        /// </summary>
        public string AoiTxt2
        {
            get
            {
                return _AoiTxt2;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _AoiTxt2 , value );

            }
        }

        private bool _IsAoi2 = false;

        /// <summary>
        ///  text 
        /// </summary>
        public bool IsAoi2
        {
            get
            {
                return _IsAoi2;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _IsAoi2 , value );

            }
        }











        private string _AoiTxt3 = "";

        /// <summary>
        ///  text 
        /// </summary>
        public string AoiTxt3
        {
            get
            {
                return _AoiTxt3;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _AoiTxt3 , value );

            }
        }

        private bool _IsAoi3 = false;

        /// <summary>
        ///  text 
        /// </summary>
        public bool IsAoi3
        {
            get
            {
                return _IsAoi3;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _IsAoi3 , value );

            }
        }




        private string _AoiTxt4 = "";

        /// <summary>
        ///  text 
        /// </summary>
        public string AoiTxt4
        {
            get
            {
                return _AoiTxt4;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _AoiTxt4 , value );

            }
        }

        private bool _IsAoi4 = false;

        /// <summary>
        ///  text 
        /// </summary>
        public bool IsAoi4
        {
            get
            {
                return _IsAoi4;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _IsAoi4 , value );

            }
        }










        public PieDontTaiPlusViewModel ()
        {
            this.createdata( new Random().Next( 2 , 5 ) );

             
        }



        void createdata ( int counts )
        {
            //特别说明：counts 最大是4

            Random _random = new Random();

            this.Series.Clear();

            this.IsAoi1 = false;
            this.AoiTxt1 = string.Empty;
            this.IsAoi2 = false;
            this.AoiTxt2 = string.Empty;
            this.IsAoi3 = false;
            this.AoiTxt3 = string.Empty;
            this.IsAoi4 = false;
            this.AoiTxt4 = string.Empty;


            for ( int i = 1 ; i <= counts ; i++ )
            {
                var num = _random.Next( 1 , 20 );
                var pie = new PieSeries<double>
                {

                    Values = new List<double>() { num } ,
                    //Name = "系列:" + num.ToString() ,
                    Fill = new SolidColorPaint( SKColors.Red ) ,

                    DataLabelsPaint = new SolidColorPaint( SKColors.Black ) ,
                    DataLabelsSize = 15 ,

                    DataLabelsFormatter = point => point.PrimaryValue.ToString()

                };

                if ( i == 1 )
                {
                    pie.Fill = new SolidColorPaint( SKColors.Red );

                    this.Series.Add( pie );

                    this.AoiTxt1 = "系列:" + num;
                    this.IsAoi1 = true;
                }

                if ( i == 2 )
                {
                    pie.Fill = new SolidColorPaint( SKColors.Yellow );

                    this.Series.Add( pie );

                    this.AoiTxt2 = "系列:" + num;
                    this.IsAoi2 = true;
                }

                if ( i == 3 )
                {
                    pie.Fill = new SolidColorPaint( SKColors.Blue );

                    this.Series.Add( pie );

                    this.AoiTxt3 = "系列:" + num;
                    this.IsAoi3 = true;
                }

                if ( i == 4 )
                {
                    pie.Fill = new SolidColorPaint( SKColors.Green );

                    this.Series.Add( pie );

                    this.AoiTxt4 = "系列:" + num;
                    this.IsAoi4 = true;
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
