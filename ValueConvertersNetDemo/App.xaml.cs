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
using Prism.Ioc;
using Prism.Unity;
using Prism.Mvvm;



namespace ValueConvertersNetDemo
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

            return Container.Resolve<Views.MainWindow>();
        }



        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {
            //注册导航
            //添加 并且起个别名  
            containerRegistry.RegisterForNavigation<Views.UC.BoolUserControl1>( "BoolUserControl1" );
            containerRegistry.RegisterForNavigation<Views.UC.DateTimeUserControl1>( "DateTimeUserControl1" );



        }



    }
}
