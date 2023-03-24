using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            Services = ConfigureServices();

            this.InitializeComponent();
        }



        private static IServiceProvider ConfigureServices ()
        {
            var services = new ServiceCollection();

            // Services  注册Services
            services.AddSingleton<IOCDemo.Service.Repository.IBill , IOCDemo.Service.Repository.BillService>();
            services.AddSingleton<IOCDemo.Service.Service.IBill , IOCDemo.Service.Service.BillService>();
            //services.AddSingleton<ISettingsService , SettingsService>();


            // Viewmodels 注册Viewmodels
            services.AddTransient<IOCDemo.ViewModels.WindowViewModel1>();

            return services.BuildServiceProvider();
        }
    }
}
