using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismDemo.NavigationDemo.Basic.UC;

namespace PrismDemo.NavigationDemo.Basic
{
    public class BaseNavigationViewModel : BindableBase
    {
        IRegionManager _regionManager;

        public BaseNavigationViewModel ( IRegionManager regionManager )
        {
            this._regionManager = regionManager;



            AButtonClickCommand = new DelegateCommand( () =>
            {
                //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
                this._regionManager.RequestNavigate( "ContentRegion" , "AUserControl" );
            } );

            BButtonClickCommand = new DelegateCommand( () =>
            {
                this._regionManager.RequestNavigate( "ContentRegion" , "BUserControl" );
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