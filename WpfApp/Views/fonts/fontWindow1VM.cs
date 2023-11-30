using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.fonts
{
    public class fontWindow1VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string _str1;
        public string Str1
        {
            get
            {
                return _str1;
            }
            set
            {
                _str1 = value;
                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Str1" ) );
            }
        }


        public MyCommand UpdateDataCommand
        {
            get; set;
        }

        public fontWindow1VM ()
        {
            //xaml直接使用Text="&#xe6d4;"，但是在后台.cs则需要改写成Text ="\xe6d4";将&#替换为\就可以了,后面的;也不要了，注意这点。
            Str1 = "\xe6d4";

            UpdateDataCommand = new MyCommand( () =>
            {
                Str1 = "\xe70b";
            } );
        }

    }
}
