using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;


/*
安装：
nuget:ValueConverters   新版本，要求。net4.8


*/

namespace ValueConvertersNetDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IRegionManager _regionManager;

        public MainWindowViewModel ( IRegionManager regionManager )
        {
            this._regionManager = regionManager;
        }



        private DelegateCommand _BoolButtonClickCommand;
        public DelegateCommand BoolButtonClickCommand => _BoolButtonClickCommand ?? ( _BoolButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "BoolUserControl1" );
        } ) );



        private DelegateCommand _DateTimeButtonClickCommand;
        public DelegateCommand DateTimeButtonClickCommand => _DateTimeButtonClickCommand ?? ( _DateTimeButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "DateTimeUserControl1" );
        } ) );



        private DelegateCommand _GroupButtonClickCommand;
        public DelegateCommand GroupButtonClickCommand => _GroupButtonClickCommand ?? ( _GroupButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "DateTimeUserControl1" );
        } ) );



    }
}
