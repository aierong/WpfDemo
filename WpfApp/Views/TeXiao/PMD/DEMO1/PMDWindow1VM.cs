using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;


namespace WpfApp.Views.TeXiao.PMD.DEMO1
{
    public class PMDWindow1VM : ViewModelBase
    {
        public PMDWindow1VM ()
        {
            Title = "123 ABC .........";

            UpdateDataCommand = new MyCommand( () =>
            {

                Title = $"{DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" )}gai le title" + " " + Title;

            } );
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
                OnPropertyChanged();

            }
        }


        public MyCommand UpdateDataCommand
        {
            get; set;
        }


    }
}
