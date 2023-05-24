﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ChartsDemo.Views.UC;
using Microsoft.Win32;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;

/*
1.安装：LiveChartsCore.SkiaSharpView.WPF  现在是预发行版，要在nuget勾选才可以找到

xmlns:lvc="clr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF"



*/

namespace ChartsDemo
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : PrismApplication
    {
        /// <summary>
        /// 设置启动起始页
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell ()
        {

            return Container.Resolve<Views.MainPage>();
        }



        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {
            //注册导航
            //注册对话框
            //添加 并且起个别名  
            containerRegistry.RegisterForNavigation<UserControlDemo1>( "UserControlDemo1" );
            //containerRegistry.RegisterForNavigation<NavigationDemo.Basic.UC.BUserControl>( "BNavigation" );


        }


    }
}