﻿using System;
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


        private DelegateCommand _Bar1ButtonClickCommand;
        public DelegateCommand Bar1ButtonClickCommand => _Bar1ButtonClickCommand ?? ( _Bar1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCBar1" );
        } ) );

        private DelegateCommand _Pie1ButtonClickCommand;
        public DelegateCommand Pie1ButtonClickCommand => _Pie1ButtonClickCommand ?? ( _Pie1ButtonClickCommand = new DelegateCommand( () =>
        {
            //RequestNavigate方法第一个参数是区域名字，第2个参数是App.xaml.cs中注册的导航名字
            this._regionManager.RequestNavigate( "ContentRegion" , "UCPie1" );
        } ) );

    }
}
