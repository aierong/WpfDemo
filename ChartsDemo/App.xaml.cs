using System;
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
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Win32;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;

/*
1.安装：LiveChartsCore.SkiaSharpView.WPF  现在是预发行版，要在nuget勾选才可以找到

xmlns:lvc="clr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF"


不支持显示中文：需要设置属性才行
SKTypeface = SKFontManager.Default.MatchCharacter( '汉' )

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



        //protected override void OnStartup ( StartupEventArgs e )
        //{
        //    base.OnStartup( e );


        //    //配置主题
        //    LiveCharts.Configure( config =>
        //        config
        //            // registers SkiaSharp as the library backend
        //            // REQUIRED unless you build your own
        //            .AddSkiaSharp()

        //            //// adds the default supported types
        //            //// OPTIONAL but highly recommend
        //            .AddDefaultMappers()

        //            // select a theme, default is Light
        //            // OPTIONAL
        //            .AddDarkTheme()
        //            //.AddLightTheme()

        //        );
        //}


        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {
            //注册导航
            //注册对话框
            //添加 并且起个别名  
            containerRegistry.RegisterForNavigation<UserControlDemo1>( "UserControlDemo1" );
            containerRegistry.RegisterForNavigation<UserControlLine1>( "UserControlLine1" );
            containerRegistry.RegisterForNavigation<UserControlLineDuo>( "UserControlLineDuo" );

            containerRegistry.RegisterForNavigation<UCBar0>( "UCBar0" );
            containerRegistry.RegisterForNavigation<BarDuo1>( "BarDuo1" );
            containerRegistry.RegisterForNavigation<Pie1>( "Pie1" );

            containerRegistry.RegisterForNavigation<LineDongTai1>( "LineDongTai1" );
            containerRegistry.RegisterForNavigation<LineDongTai2>( "LineDongTai2" );

            containerRegistry.RegisterForNavigation<UCBarLine1>( "UCBarLine1" );
            containerRegistry.RegisterForNavigation<BarDongTai1>( "BarDongTai1" );
            containerRegistry.RegisterForNavigation<BarDongTai2>( "BarDongTai2" );

            containerRegistry.RegisterForNavigation<PieDontTai1>( "PieDontTai1" );
            containerRegistry.RegisterForNavigation<PieDontTai2>( "PieDontTai2" );
            containerRegistry.RegisterForNavigation<PieDontTaiPlus>( "PieDontTaiPlus" );

            containerRegistry.RegisterForNavigation<UserControl123>( "UserControl123" );
            containerRegistry.RegisterForNavigation<UCBarRow1>( "UCBarRow1" );

            containerRegistry.RegisterForNavigation<UCBarRow1DongTai>( "UCBarRow1DongTai" );
            containerRegistry.RegisterForNavigation<MultipleAxesUserControl1>( "MultipleAxesUserControl1" );

        }



    }
}
