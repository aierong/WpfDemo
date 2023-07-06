using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Prism.Events;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using Prism.Unity;



namespace PrismDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        //Application启动执行顺序: PrismApplication_Startup   ConfigureViewModelLocator   RegisterTypes   CreateShell   OnInitialized 



        /// <summary>
        /// 设置启动起始页
        /// </summary>
        /// <returns></returns>
        protected override Window CreateShell ()
        {
            //捕捉未处理的异常
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;

            Debug.WriteLine( "CreateShell" );



            //return Container.Resolve<Views.Window1>();

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
            //return Container.Resolve<NavigationDemo.Basic.BaseNavigation>();
            //导航传递参数 
            //return Container.Resolve<NavigationDemo.Parameters.ParametersNavigation>();
            //确定导航
            //return Container.Resolve<NavigationDemo.ConfirmNavigation.ConfirmNavigationPage>();



            //对话框
            //return Container.Resolve<DialogDemo.DialogWindow>();



            //ioc
            //return Container.Resolve<IOCDemo.Demo1.IOCWindowOne>();



            //日志
            return Container.Resolve<LogDemo.LogWindow>();


            //测试登录  
            // 记得，如果使用下面的登录，请把下面屏蔽的OnInitialized代码打开
            //return Container.Resolve<LoginDemo.Demo2.MainIndex>();
        }

        private void App_DispatcherUnhandledException ( object sender , System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e )
        {
            try
            {
                e.Handled = true; //标识异常已经处理

                if ( e.Exception.InnerException == null )
                {
                    //MessageBox.Show( "（1）发生了一个错误！请联系开发人员！" + Environment.NewLine
                    //                   + "（2）错误源：" + e.Exception.Source + Environment.NewLine
                    //                   + "（3）详细信息：" + e.Exception.Message + Environment.NewLine );
                    //+ "（4）报错区域：" + e.Exception.StackTrace);

                    this.logger.LogError( $"{e.Exception.StackTrace}" + Environment.NewLine + $"{e.Exception.Message}" );

                }
                else
                {
                    //MessageBox.Show( "（1）发生了一个错误！请联系开发人员！" + Environment.NewLine
                    //                    + "（2）错误源：" + e.Exception.InnerException.Source + Environment.NewLine
                    //                    + "（3）错误信息：" + e.Exception.Message + Environment.NewLine
                    //                    + "（4）详细信息：" + e.Exception.InnerException.Message + Environment.NewLine
                    //                    + "（5）报错区域：" + e.Exception.InnerException.StackTrace );

                    this.logger.LogError( $"{e.Exception.InnerException.StackTrace}" + Environment.NewLine + $"{e.Exception.InnerException.Message}{e.Exception.InnerException.Source}" );
                }

            }
            catch ( Exception e2 )
            {
                //此时程序出现严重异常，将强制结束退出
                //MessageBox.Show( "程序发生致命错误，将终止，请联系运营商！" );
            }
            finally
            {

            }
        }



        private void PrismApplication_Exit ( object sender , ExitEventArgs e )
        {
            Debug.WriteLine( "PrismApplication_Exit" );
        }



        private void PrismApplication_Startup ( object sender , StartupEventArgs e )
        {
            Debug.WriteLine( "PrismApplication_Startup" );
        }



        //protected override void OnInitialized ()
        //{
        //    base.OnInitialized();

        //    Debug.WriteLine( "OnInitialized" );
        //}


        //protected override void OnInitialized ()
        //{
        //    /* 参考:
        //    https://blog.csdn.net/u010197227/article/details/126029393

        //    */

        //    var dialog = Container.Resolve<IDialogService>();

        //    //systemlogin
        //    dialog.ShowDialog( "systemlogin" , ( IDialogResult callback ) =>
        //    {
        //        if ( callback.Result != ButtonResult.OK )
        //        {
        //            Environment.Exit( 0 );

        //            return;
        //        }

        //        var userid = string.Empty;
        //        var username = string.Empty;

        //        //这里，可以收到弹窗返回的值
        //        if ( callback.Parameters.ContainsKey( "userid" ) )
        //        {
        //            userid = callback.Parameters.GetValue<string>( "userid" );
        //        }

        //        if ( callback.Parameters.ContainsKey( "username" ) )
        //        {
        //            username = callback.Parameters.GetValue<string>( "username" );
        //        }

        //        //给主窗体传值
        //        base.OnInitialized();



        //        //给主窗体传递值：1.可以用静态变量  2.用Prism的消息发送数据

        //        var _eventAggregator = Container.Resolve<IEventAggregator>();
        //        //发送消息
        //        _eventAggregator.GetEvent<LoginDemo.Demo2.SentEvent>().Publish( "123" );

        //    } );


        //}

        Microsoft.Extensions.Logging.ILogger logger;

        protected override void RegisterTypes ( IContainerRegistry containerRegistry )
        {
            Debug.WriteLine( "RegisterTypes" );



            /*
            安装：NLog.Extensions.Logging
            */

            var factory = new NLog.Extensions.Logging.NLogLoggerFactory();
            this.logger = factory.CreateLogger( "" );
            //下面这个是加载指定名字  nlog.config里面：    <logger name="mylognameabc" level="Info" writeTo="mylogfileabc"/>
            //Microsoft.Extensions.Logging.ILogger logger = factory.CreateLogger( "mylognameabc" );
            containerRegistry.RegisterInstance( logger );



            //注册导航

            //添加 并且起个别名  
            containerRegistry.RegisterForNavigation<NavigationDemo.Basic.UC.AUserControl>( "ANavigation" );
            containerRegistry.RegisterForNavigation<NavigationDemo.Basic.UC.BUserControl>( "BNavigation" );

            containerRegistry.RegisterForNavigation<NavigationDemo.Parameters.UC.UserControl111>( "Navigation111" );
            containerRegistry.RegisterForNavigation<NavigationDemo.Parameters.UC.UserControl222>( "Navigation222" );

            containerRegistry.RegisterForNavigation<NavigationDemo.ConfirmNavigation.UC.UserControlAAA>( "NavigationAAA" );
            containerRegistry.RegisterForNavigation<NavigationDemo.ConfirmNavigation.UC.UserControlBBB>( "NavigationBBB" );

            containerRegistry.RegisterForNavigation<LoginDemo.Demo2.UC.UCChild1>( "NavigationChild1" );
            containerRegistry.RegisterForNavigation<LoginDemo.Demo2.UC.UCChild2>( "NavigationChild2" );



            //注册对话框
            //并且给对话框起名
            containerRegistry.RegisterDialog<DialogDemo.Dialogs.UserDialog , DialogDemo.Dialogs.UserDialogViewModel>( "mydlgone" );



            //ioc
            containerRegistry.RegisterSingleton<IOCDemo.Demo1.Service.Service.IBill , IOCDemo.Demo1.Service.Service.BillService>();
            containerRegistry.RegisterSingleton<IOCDemo.Demo1.Service.Repository.IBill , IOCDemo.Demo1.Service.Repository.BillService>();


            //同一个接口，多个服务实现
            //分别起一个名字，这样注入时，我们可以区分
            containerRegistry.RegisterSingleton<IOCDemo.Demo1.Service.IPerson , IOCDemo.Demo1.Service.Man>( "man" );
            containerRegistry.RegisterSingleton<IOCDemo.Demo1.Service.IPerson , IOCDemo.Demo1.Service.Woman>( "woman" );

            //通过实例的方式注册的对象属于单例
            //containerRegistry.RegisterInstance<IOCDemo.Demo1.Service.IPerson>( new IOCDemo.Demo1.Service.Man() { Name ="qq" } );
            //containerRegistry.RegisterInstance<IOCDemo.Demo1.Service.IPerson>( new IOCDemo.Demo1.Service.Man() { Name = "qq" } ,"man");


            // 日志
            containerRegistry.RegisterForNavigation<LogDemo.UC.AAAUserControl>( "AAAUC" );
            containerRegistry.RegisterForNavigation<LogDemo.UC.BBBUserControl>( "BBBUC" );




            //
            containerRegistry.RegisterDialog<LoginDemo.Demo2.UCLogin , LoginDemo.Demo2.UCLoginViewModel>( "systemlogin" );

        }




        /// <summary>
        /// 配置规则
        /// </summary>
        protected override void ConfigureViewModelLocator ()
        {
            Debug.WriteLine( "ConfigureViewModelLocator" );



            base.ConfigureViewModelLocator();

            //手动指定一个view与vm绑定关系
            //Register方法指定的第1个类型是视图名，第2哥类型是VM名
            ViewModelLocationProvider.Register<Views.Window1 , ViewModels.vm1>();
            ViewModelLocationProvider.Register( typeof( Views.Window2 ).ToString() , typeof( ViewModels.vm.classtwo ) );



            //消息事件
            ViewModelLocationProvider.Register<EventDemo.EventMainPage , EventDemo.EventMainPageViewModel>();
            ViewModelLocationProvider.Register<EventDemo.UC.UserControlLeft , EventDemo.UC.UserControlLeftViewModel>();
            ViewModelLocationProvider.Register<EventDemo.UC.UserControlTop , EventDemo.UC.UserControlTopViewModel>();



            //区域 
            ViewModelLocationProvider.Register<RegionDemo.View.RegionDemo1 , RegionDemo.ViewModel.RegionDemo1ViewModel>();



            //导航
            ViewModelLocationProvider.Register<NavigationDemo.Basic.BaseNavigation , NavigationDemo.Basic.BaseNavigationViewModel>();
            //导航传递参数
            ViewModelLocationProvider.Register<NavigationDemo.Parameters.ParametersNavigation , NavigationDemo.Parameters.ParametersNavigationViewModel>();
            ViewModelLocationProvider.Register<NavigationDemo.Parameters.UC.UserControl111 , NavigationDemo.Parameters.UC.UserControl111ViewModel>();
            ViewModelLocationProvider.Register<NavigationDemo.Parameters.UC.UserControl222 , NavigationDemo.Parameters.UC.UserControl222ViewModel>();
            //确定导航
            ViewModelLocationProvider.Register<NavigationDemo.ConfirmNavigation.UC.UserControlAAA , NavigationDemo.ConfirmNavigation.UC.UserControlAAAViewModel>();
            ViewModelLocationProvider.Register<NavigationDemo.ConfirmNavigation.ConfirmNavigationPage , NavigationDemo.ConfirmNavigation.ConfirmNavigationPageViewModel>();



            //弹窗
            ViewModelLocationProvider.Register<DialogDemo.DialogWindow , DialogDemo.DialogWindowViewModel>();
            ViewModelLocationProvider.Register<DialogDemo.Dialogs.UserDialog , DialogDemo.Dialogs.UserDialogViewModel>();



            //ioc  
            ViewModelLocationProvider.Register<IOCDemo.Demo1.IOCWindowOne , IOCDemo.Demo1.IOCWindowOneViewModel>();


            //日志
            ViewModelLocationProvider.Register<LogDemo.UC.AAAUserControl , LogDemo.UC.AAAUserControlViewModel>();
            ViewModelLocationProvider.Register<LogDemo.LogWindow , LogDemo.LogWindowViewModel>();







            //测试登录窗体 demo2
            ViewModelLocationProvider.Register<LoginDemo.Demo2.MainIndex , LoginDemo.Demo2.MainIndexViewModel>();
            ViewModelLocationProvider.Register<LoginDemo.Demo2.UCLogin , LoginDemo.Demo2.UCLoginViewModel>();
            ViewModelLocationProvider.Register<LoginDemo.Demo2.UC.UCChild1 , LoginDemo.Demo2.UC.UCChild1VM>();
            ViewModelLocationProvider.Register<LoginDemo.Demo2.UC.UCChild2 , LoginDemo.Demo2.UC.UCChild2VM>();




            //我们可以指定view存放在某个文件夹,VM存放在某个文件夹，并且指定2者的命名规则
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver( ( viewType ) =>
            {
                //视图在MyView文件夹，viewmodel在MyVm文件夹
                var viewName = viewType.FullName.Replace( ".MyView." , ".MyVm." );
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                //viewmodel的名字是视图名字后面加VM
                //例如:WinOne.xaml会自动绑定WinOneVM.cs
                //例如:ModuleABC目录下UserData.xaml会自动绑定ModuleABC目录下UserDataVM.cs
                var viewModelName = $"{viewName}VM, {viewAssemblyName}";
                return Type.GetType( viewModelName );
            } );


        }



    }
}
