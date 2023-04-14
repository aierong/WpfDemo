using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismDemo.NavigationDemo.Parameters
{
    public class ParametersNavigationViewModel : BindableBase
    {
        IRegionManager _regionManager;


        /// <summary>
        /// IRegionManager依赖注入
        /// </summary>
        public ParametersNavigationViewModel ( IRegionManager regionManager )
        {
            this._regionManager = regionManager;



            Par1ButtonClickCommand = new DelegateCommand( () =>
            {
                var param = new NavigationParameters();
                param.Add( "P1" , "str1" );

                //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字,第3个是传达的参数
                this._regionManager.RequestNavigate( "ContentRegion" , "AUserControl" , param );
            } );

            Par2ButtonClickCommand = new DelegateCommand( () =>
            {
                this._regionManager.RequestNavigate( "ContentRegion" , "BUserControl" );
            } );
        }

        public DelegateCommand Par1ButtonClickCommand
        {
            get; private set;
        }



        public DelegateCommand Par2ButtonClickCommand
        {
            get; private set;
        }
    }
}
