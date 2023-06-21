using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;



namespace ChartsDemo.ViewModels
{
    public  class MainPageViewModel : BindableBase
    {
        IRegionManager _regionManager;

        public MainPageViewModel( IRegionManager regionManager )
        {
            this._regionManager = regionManager;
        }



        private DelegateCommand _AButtonClickCommand;
        public DelegateCommand AButtonClickCommand => _AButtonClickCommand ?? ( _AButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UserControlDemo1" );
        } ) );

        private DelegateCommand _CYButtonClickCommand;
        public DelegateCommand CYButtonClickCommand => _CYButtonClickCommand ?? ( _CYButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UserControl123" );
        } ) );



        private DelegateCommand _LineButtonClickCommand;
        public DelegateCommand LineButtonClickCommand => _LineButtonClickCommand ?? ( _LineButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UserControlLine1" );
        } ) );



        private DelegateCommand _LineDuoButtonClickCommand;
        public DelegateCommand LineDuoButtonClickCommand => _LineDuoButtonClickCommand ?? ( _LineDuoButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UserControlLineDuo" );
        } ) );



        private DelegateCommand _Bar0ButtonClickCommand;
        public DelegateCommand Bar0ButtonClickCommand => _Bar0ButtonClickCommand ?? ( _Bar0ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCBar0" );
        } ) );



        private DelegateCommand _Bar1ButtonClickCommand;
        public DelegateCommand Bar1ButtonClickCommand => _Bar1ButtonClickCommand ?? ( _Bar1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCBar1" );
        } ) );



        private DelegateCommand _BarLine1ButtonClickCommand;
        public DelegateCommand BarLine1ButtonClickCommand => _BarLine1ButtonClickCommand ?? ( _BarLine1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCBarLine1" );
        } ) );



        private DelegateCommand _Pie1ButtonClickCommand;
        public DelegateCommand Pie1ButtonClickCommand => _Pie1ButtonClickCommand ?? ( _Pie1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "Pie1" );
        } ) );



        private DelegateCommand _DongTai1ButtonClickCommand;
        public DelegateCommand DongTai1ButtonClickCommand => _DongTai1ButtonClickCommand ?? ( _DongTai1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCDongTai1" );
        } ) );



        private DelegateCommand _DongTaiBar1ButtonClickCommand;
        public DelegateCommand DongTaiBar1ButtonClickCommand => _DongTaiBar1ButtonClickCommand ?? ( _DongTaiBar1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "BarDongTai1" );
        } ) );


        
        private DelegateCommand _PieDontTai0ButtonClickCommand;
        public DelegateCommand PieDontTai0ButtonClickCommand => _PieDontTai0ButtonClickCommand ?? ( _PieDontTai0ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "PieDontTai1" );
        } ) );



        private DelegateCommand _PieDontTai2ButtonClickCommand;
        public DelegateCommand PieDontTai2ButtonClickCommand => _PieDontTai2ButtonClickCommand ?? ( _PieDontTai2ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "PieDontTai2" );
        } ) );


      
        private DelegateCommand _PieDontTaiPlusButtonClickCommand;
        public DelegateCommand PieDontTaiPlusButtonClickCommand => _PieDontTaiPlusButtonClickCommand ?? ( _PieDontTaiPlusButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "PieDontTaiPlus" );
        } ) );



        private DelegateCommand _BarRow1ButtonClickCommand;
        public DelegateCommand BarRow1ButtonClickCommand => _BarRow1ButtonClickCommand ?? ( _BarRow1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCBarRow1" );
        } ) );
    }
}
