using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using FluentScheduler;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.DH
{
    public class Window1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Window1ViewModel ()
        {
            Title = "Titleinit";

            ShowCommand = new MyCommand( Show );

            FluentScheduler.JobManager.Initialize();

            JobManager.AddJob(
            () =>
            {

                Show();
            } ,
            s =>
            {
                //5秒钟一次
                //s.ToRunEvery( 5 ).Seconds();
                //1分钟一次
                s.ToRunEvery( 1 ).Minutes();
            });
        }


        public void Show ()
        {
            Title = "gang gang gai le title time:" + DateTime.Now.ToLongTimeString();
        }


        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }


        private string title;


        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get => title;

            set
            {
                title = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Title" ) );
            }
        }

    }
}
