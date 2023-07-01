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
    public class MainPageViewModel : BindableBase
    {
        IRegionManager _regionManager;

        public MainPageViewModel ( IRegionManager regionManager )
        {
            this._regionManager = regionManager;
        }



        private DelegateCommand _AButtonClickCommand;
        public DelegateCommand AButtonClickCommand => _AButtonClickCommand ?? ( _AButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate(  Common.Common.RegionName , "UserControlDemo1" );
        } ) );

        private DelegateCommand _CYButtonClickCommand;
        public DelegateCommand CYButtonClickCommand => _CYButtonClickCommand ?? ( _CYButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "UserControl123" );
        } ) );



        private DelegateCommand _LineButtonClickCommand;
        public DelegateCommand LineButtonClickCommand => _LineButtonClickCommand ?? ( _LineButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "UserControlLine1" );
        } ) );



        private DelegateCommand _LineDuoButtonClickCommand;
        public DelegateCommand LineDuoButtonClickCommand => _LineDuoButtonClickCommand ?? ( _LineDuoButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "UserControlLineDuo" );
        } ) );



        private DelegateCommand _Bar0ButtonClickCommand;
        public DelegateCommand Bar0ButtonClickCommand => _Bar0ButtonClickCommand ?? ( _Bar0ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "Bar0" );
        } ) );



        private DelegateCommand _BarDuo1ButtonClickCommand;
        public DelegateCommand BarDuo1ButtonClickCommand => _BarDuo1ButtonClickCommand ?? ( _BarDuo1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "BarDuo1" );
        } ) );



        private DelegateCommand _BarLine1ButtonClickCommand;
        public DelegateCommand BarLine1ButtonClickCommand => _BarLine1ButtonClickCommand ?? ( _BarLine1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "UCBarLine1" );
        } ) );



        private DelegateCommand _Pie1ButtonClickCommand;
        public DelegateCommand Pie1ButtonClickCommand => _Pie1ButtonClickCommand ?? ( _Pie1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "Pie1" );
        } ) );



        private DelegateCommand _LineDongTai1ButtonClickCommand;
        public DelegateCommand LineDongTai1ButtonClickCommand => _LineDongTai1ButtonClickCommand ?? ( _LineDongTai1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "LineDongTai1" );
        } ) );

       

        private DelegateCommand _LineDongTai2ButtonClickCommand;
        public DelegateCommand LineDongTai2ButtonClickCommand => _LineDongTai2ButtonClickCommand ?? ( _LineDongTai2ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "LineDongTai2" );
        } ) );



        private DelegateCommand _DongTaiBar1ButtonClickCommand;
        public DelegateCommand DongTaiBar1ButtonClickCommand => _DongTaiBar1ButtonClickCommand ?? ( _DongTaiBar1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "BarDongTai1" );
        } ) );



        private DelegateCommand _DongTaiBar2ButtonClickCommand;
        public DelegateCommand DongTaiBar2ButtonClickCommand => _DongTaiBar2ButtonClickCommand ?? ( _DongTaiBar2ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "BarDongTai2" );
        } ) );


        private DelegateCommand _PieDontTai0ButtonClickCommand;
        public DelegateCommand PieDontTai0ButtonClickCommand => _PieDontTai0ButtonClickCommand ?? ( _PieDontTai0ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "PieDontTai1" );
        } ) );



        private DelegateCommand _PieDontTai2ButtonClickCommand;
        public DelegateCommand PieDontTai2ButtonClickCommand => _PieDontTai2ButtonClickCommand ?? ( _PieDontTai2ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "PieDontTai2" );
        } ) );



        private DelegateCommand _PieDontTaiPlusButtonClickCommand;
        public DelegateCommand PieDontTaiPlusButtonClickCommand => _PieDontTaiPlusButtonClickCommand ?? ( _PieDontTaiPlusButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "PieDontTaiPlus" );
        } ) );



        private DelegateCommand _BarRow1ButtonClickCommand;
        public DelegateCommand BarRow1ButtonClickCommand => _BarRow1ButtonClickCommand ?? ( _BarRow1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "UCBarRow1" );
        } ) );


        private DelegateCommand _UCBarRow1DongTaiButtonClickCommand;
        public DelegateCommand UCBarRow1DongTaiButtonClickCommand => _UCBarRow1DongTaiButtonClickCommand ?? ( _UCBarRow1DongTaiButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "UCBarRow1DongTai" );
        } ) );


        //
        private DelegateCommand _MultipleAxesButtonClickCommand;
        public DelegateCommand MultipleAxesButtonClickCommand => _MultipleAxesButtonClickCommand ?? ( _MultipleAxesButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( Common.Common.RegionName , "MultipleAxesUserControl1" );
        } ) );

    }
}
