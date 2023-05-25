using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismDemo.LoginDemo.Demo2
{
    public  class MainIndexViewModel : BindableBase
    {
        private string _TextTitle = "init—vm";

        public string TextTitle
        {
            get
            {
                return _TextTitle;
            }
            set
            {
                SetProperty( ref _TextTitle , value );
            }
        }



        IRegionManager _regionManager;

        public MainIndexViewModel( IRegionManager regionManager )
        {
            this._regionManager = regionManager;

            TextTitle = "主窗体(Main)";
        }


        private DelegateCommand _AClickCommand;
        /// <summary>
        /// 登录操作
        /// </summary>
        public DelegateCommand AClickCommand => _AClickCommand ?? ( _AClickCommand = new DelegateCommand( () =>
        {

            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "NavigationChild1" );


        } ) );


        private DelegateCommand _BClickCommand;
        /// <summary>
        /// 登录操作
        /// </summary>
        public DelegateCommand BClickCommand => _BClickCommand ?? ( _BClickCommand = new DelegateCommand( () =>
        {

            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "NavigationChild2" );


        } ) );

    }
}
