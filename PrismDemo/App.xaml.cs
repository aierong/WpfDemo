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
using Prism.Mvvm;
using Prism.Unity;





namespace PrismDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        /// <summary>
        /// 设置启动起始页
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell ()
        {
            //return Container.Resolve<Views.MainWindow>();
            //return Container.Resolve<TestWindow>();
            //return Container.Resolve<Views.v1.LG.MYWin>();
            //return Container.Resolve<Views.Window2>();



            //手动指定模块绑定
            //return Container.Resolve<MyView.WinOne>();
            //return Container.Resolve<MyView.ModuleABC.UserData>();



            //模型命令demo 
            //return Container.Resolve<DataDemo.View.ModelData>();



            // 事件消息
            //return Container.Resolve<EventDemo.EventMainPage>();



            //区域 
            //return Container.Resolve<RegionDemo.View.RegionDemo1>();



            //导航
            return Container.Resolve<NavigationDemo.Basic.BaseNavigation>();


            //return Container.Resolve<Views.Window1>();
        }



        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {
            //注册导航

            //添加 并且起个别名 "AUserControl"
            containerRegistry.RegisterForNavigation<NavigationDemo.Basic.UC.AUserControl>( "AUserControl" );
            containerRegistry.RegisterForNavigation<NavigationDemo.Basic.UC.BUserControl>( "BUserControl" );

             
        }



        /// <summary>
        /// 配置规则
        /// </summary>
        protected override void ConfigureViewModelLocator ()
        {
            //手动指定一个view与vm绑定关系
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<Views.Window1 , ViewModels.vm1>();
            ViewModelLocationProvider.Register( typeof( Views.Window2 ).ToString() , typeof( ViewModels.vm.classtwo ) );



            //消息事件
            ViewModelLocationProvider.Register<EventDemo.EventMainPage , EventDemo.EventMainPageViewModel>();
            ViewModelLocationProvider.Register<EventDemo.UC.UserControlLeft, EventDemo.UC.UserControlLeftViewModel>();
            ViewModelLocationProvider.Register<EventDemo.UC.UserControlTop , EventDemo.UC.UserControlTopViewModel>();



            //区域 
            ViewModelLocationProvider.Register<RegionDemo.View.RegionDemo1, RegionDemo.ViewModel.RegionDemo1ViewModel>();



            //导航
            ViewModelLocationProvider.Register<NavigationDemo.Basic.BaseNavigation, NavigationDemo.Basic.BaseNavigationViewModel>();



            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver( ( viewType ) =>
            {
                //视图在MyView文件夹，viewmodel在MyVm文件夹
                var viewName = viewType.FullName.Replace( ".MyView." , ".MyVm." );
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                //viewmodel的名字是视图名字后面加VM
                var viewModelName = $"{viewName}VM, {viewAssemblyName}";
                return Type.GetType( viewModelName );
            } );


 


            //base.ConfigureViewModelLocator();
            //ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver( ( viewType ) =>
            //{
            //    var viewName = viewType.FullName.Replace( ".Viewsb." , ".ViewModelsa.OhMyGod." );
            //    var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
            //    var viewModelName = $"{viewName}Test, {viewAssemblyName}";
            //    return Type.GetType( viewModelName );
            //} );
        }



    }
}
