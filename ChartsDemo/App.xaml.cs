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
using Microsoft.Win32;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;

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

            return Container.Resolve<Views.Window1>();
        }


        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {
            //注册导航
            //注册对话框

        }


    }
}
