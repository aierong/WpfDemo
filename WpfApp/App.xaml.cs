using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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

        

            Debug.WriteLine( "Application_Startup" );
        }



        protected override void OnStartup ( StartupEventArgs e )
        {
            // Application_Startup 在  OnStartup 前运行

            base.OnStartup( e );

            //捕捉未处理的异常
            //this.DispatcherUnhandledException += App_DispatcherUnhandledException;

            Debug.WriteLine( "OnStartup" );



            //bool initiallyOwned = true;
            //bool isCreated;
            //Mutex m = new Mutex( initiallyOwned , "动画" , out isCreated );
            //if ( isCreated != true )
            //{
            //    MessageBox.Show( "已经有相同的实例在运行。" , "提示" );

            //    Shutdown();

            //    return;
            //}

            //System.Threading.Mutex mutex = null;
            //bool isExists = System.Threading.Mutex.TryOpenExisting( GlobalMutexName , out mutex );
            //if ( isExists && null != mutex )
            //{
            //    //表示互斥体已经存在，即已经打开了一个程序，这里提示用户
            //    MessageBox.Show( "程序已经在运行" );
            //    return;
            //}
        }



        const string GlobalMutexName = "WpfApp";



        //private void App_DispatcherUnhandledException ( object sender , System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e )
        //{
        //    //https://blog.csdn.net/wode17/article/details/106603707

        //    try
        //    {
        //        e.Handled = true; //标识异常已经处理

        //        if ( e.Exception.InnerException == null )
        //        {
        //            MessageBox.Show( "（1）发生了一个错误！请联系开发人员！" + Environment.NewLine
        //                               + "（2）错误源：" + e.Exception.Source + Environment.NewLine
        //                               + "（3）详细信息：" + e.Exception.Message + Environment.NewLine );
        //            //+ "（4）报错区域：" + e.Exception.StackTrace);
        //        }
        //        else
        //        {
        //            MessageBox.Show( "（1）发生了一个错误！请联系开发人员！" + Environment.NewLine
        //                                + "（2）错误源：" + e.Exception.InnerException.Source + Environment.NewLine
        //                                + "（3）错误信息：" + e.Exception.Message + Environment.NewLine
        //                                + "（4）详细信息：" + e.Exception.InnerException.Message + Environment.NewLine
        //                                + "（5）报错区域：" + e.Exception.InnerException.StackTrace );
        //        }

        //    }
        //    catch ( Exception e2 )
        //    {
        //        //此时程序出现严重异常，将强制结束退出
        //        MessageBox.Show( "程序发生致命错误，将终止，请联系运营商！" );
        //    }
        //    finally
        //    {

        //    }
        //}



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



        private void Application_DispatcherUnhandledException ( object sender , System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e )
        {
            //https://wpf-tutorial.com/zh/13/wpf%E6%87%89%E7%94%A8%E7%A8%8B%E5%BC%8F/%E5%9C%A8wpf%E4%B8%AD%E8%99%95%E7%90%86%E4%BE%8B%E5%A4%96/




            try
            {
                e.Handled = true; //标识异常已经处理

                if ( e.Exception.InnerException == null )
                {
                    MessageBox.Show( "（1）发生了一个错误！请联系开发人员！" + Environment.NewLine
                                       + "（2）错误源：" + e.Exception.Source + Environment.NewLine
                                       + "（3）详细信息：" + e.Exception.Message + Environment.NewLine );
                    //+ "（4）报错区域：" + e.Exception.StackTrace);
                }
                else
                {
                    MessageBox.Show( "（1）发生了一个错误！请联系开发人员！" + Environment.NewLine
                                        + "（2）错误源：" + e.Exception.InnerException.Source + Environment.NewLine
                                        + "（3）错误信息：" + e.Exception.Message + Environment.NewLine
                                        + "（4）详细信息：" + e.Exception.InnerException.Message + Environment.NewLine
                                        + "（5）报错区域：" + e.Exception.InnerException.StackTrace );
                }

            }
            catch ( Exception e2 )
            {
                //此时程序出现严重异常，将强制结束退出
                MessageBox.Show( "程序发生致命错误，将终止，请联系运营商！" );
            }
            finally
            {

            }
        }
    }
}
