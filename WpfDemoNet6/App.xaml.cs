using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;


//nuget 安装:Microsoft.Extensions.DependencyInjection

namespace WpfDemoNet6
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => ( App ) Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services
        {
            get;
        }

        public App ()
        {
            Debug.WriteLine( "App" );

            Services = ConfigureServices();

            this.InitializeComponent();
        }

        private static IServiceProvider ConfigureServices ()
        {
            Debug.WriteLine( "ConfigureServices" );

            var services = new ServiceCollection();

            //    注册Services
            services.AddSingleton<IOCDemo.Service.Repository.IBill , IOCDemo.Service.Repository.BillService>();
            services.AddSingleton<IOCDemo.Service.Service.IBill , IOCDemo.Service.Service.BillService>();
            //services.AddSingleton<ISettingsService , SettingsService>();


            //  注册Viewmodels
            // 不是每个Viewmodels都得来AddTransient,如果Viewmodels不需要ioc,可以不用这里注册
            services.AddTransient<IOCDemo.ViewModels.WindowViewModel1>();


            return services.BuildServiceProvider();
        }



        protected override void OnStartup ( StartupEventArgs e )
        {
            base.OnStartup( e );

            Debug.WriteLine( "OnStartup" );

            //这里调用,注入的方法
            var ser = App.Current.Services.GetService<IOCDemo.Service.Service.IBill>();
            var str1 = ser?.GetData( "app" );
        }



        private void Application_Exit ( object sender , ExitEventArgs e )
        {
            Debug.WriteLine( "Application_Exit" );
        }



        //private void Application_Startup ( object sender , StartupEventArgs e )
        //{
        //    //特别注意:CommunityToolkit.Mvvm中不要使用Application_Startup,好像会运行2次,请使用override OnStartup

        //    Debug.WriteLine( "Application_Startup" );



        //    //这里调用,注入的方法
        //    //var ser = App.Current.Services.GetService<IOCDemo.Service.Service.IBill>();
        //    //var str1 = ser?.GetData( "app" );
        //}



    }
}
