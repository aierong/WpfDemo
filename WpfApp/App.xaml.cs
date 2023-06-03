using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup ( object sender , StartupEventArgs e )
        {
            //xaml中注册Startup = "Application_Startup"

            var a = 1;

            var b = 2;

            Debug.WriteLine( "Application_Startup" );
        }

        

        protected override void OnStartup ( StartupEventArgs e )
        {
            // Application_Startup 在  OnStartup 前运行

            base.OnStartup( e );

            var a = 1;

            var b = 2;

            Debug.WriteLine( "OnStartup" );
        }



        private void Application_Exit ( object sender , ExitEventArgs e )
        {
            //xaml中注册Exit="Application_Exit"
            //在应用程序关闭之前发生
            var a = 1;

            var b = 2;
        }



        private void Application_Activated ( object sender , EventArgs e )
        {
            //xaml中注册Activated="Application_Activated"
            //当应用程序成为前台应用程序时发生。 会多次发生
            var a = 1;

            var b = 2;

            Debug.WriteLine( "Application_Activated" );
        }
    }
}
