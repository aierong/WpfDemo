using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismDemo.NavigationDemo.ConfirmNavigation
{
    public class ConfirmNavigationPageViewModel : BindableBase
    {
        IRegionManager _regionManager;

        /// <summary>
        /// IRegionManager依赖注入
        /// </summary>
        /// <param name="regionManager"></param>
        public ConfirmNavigationPageViewModel ( IRegionManager regionManager )
        {
            this._regionManager = regionManager;



            AButtonClickCommand = new DelegateCommand( () =>
            {
                //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
                this._regionManager.RequestNavigate( "ContentRegion" , "NavigationAAA" );
            } );

            BButtonClickCommand = new DelegateCommand( () =>
            {
                this._regionManager.RequestNavigate( "ContentRegion" , "NavigationBBB" );
            } );
        }

        public DelegateCommand AButtonClickCommand
        {
            get; private set;
        }



        public DelegateCommand BButtonClickCommand
        {
            get; private set;
        }
    }
}
