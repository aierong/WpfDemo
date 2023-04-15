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
                //传递2个参数
                var param = new NavigationParameters();
                param.Add( "ptitle" , "str1" );
                param.Add( "num" , 12345 );
                param.Add( "listdata" , new List<string>() { "a111" , "b222" , "c333" } );

                //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字,第3个是传达的参数
                this._regionManager.RequestNavigate( "ContentRegion" , "UC111" , param );
            } );

            Par2ButtonClickCommand = new DelegateCommand( () =>
            {
                //如果要传递的参数简单,也可以使用类似web querystring 那样传递参数
                this._regionManager.RequestNavigate( "ContentRegion" , "UC222?p1=srt222&p2=123" );
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
