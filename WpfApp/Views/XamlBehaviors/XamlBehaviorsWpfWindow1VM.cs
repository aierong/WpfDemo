using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.XamlBehaviors
{
    public class XamlBehaviorsWpfWindow1VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public MyCommand UpdateDataCommand
        {
            get; set;
        }

        public XamlBehaviorsWpfWindow1VM ()
        {


            UpdateDataCommand = new MyCommand( () =>
            {

                Str1 = DateTime.Now.ToLongTimeString();

            } );

            RightUpdateDataCommand = new MyCommand( () =>
            {

                Str2 = DateTime.Now.ToLongTimeString();

            } );

            RightDataCommand = new MyCommand( () =>
            {

                Str3 = DateTime.Now.ToLongTimeString();

            } );
        }


        public MyCommand RightUpdateDataCommand
        {
            get; set;
        }

        public string str1 = "qq";
        public string Str1
        {
            get
            {
                return str1;
            }
            set
            {
                str1 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Str1" ) );
            }
        }


        public string str2 = "鼠标右键点击我";
        public string Str2
        {
            get
            {
                return str2;
            }
            set
            {
                str2 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Str2" ) );
            }
        }


        public string str3 = "鼠标右键点击我";
        public string Str3
        {
            get
            {
                return str3;
            }
            set
            {
                str3 = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Str3" ) );
            }
        }

        public MyCommand RightDataCommand
        {
            get; set;
        }

    }
}
