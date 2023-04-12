using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
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
            return Container.Resolve<Views.Window2>();

            //return Container.Resolve<Views.Window1>();
        }



        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {

        }



        /// <summary>
        /// 配置规则
        /// </summary>
        protected override void ConfigureViewModelLocator ()
        {
            //手动指定一个view与vm绑定关系
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<Views.Window1, ViewModels.vm1>();
            ViewModelLocationProvider.Register( typeof( Views.Window2 ).ToString() , typeof(ViewModels.vm.classtwo) );



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
