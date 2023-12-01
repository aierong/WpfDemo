using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.svgdemo
{
    public class svgViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public svgViewModel ()
        {
            ShowCommand = new MyCommand( () => Txt = "/assets/svg/2_2.svg" );
        }


        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }


        private string _txt = "/assets/svg/baogao.svg";


        public string Txt
        {
            get => _txt;

            set
            {
                _txt = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Txt" ) );
            }
        }
    }
}
