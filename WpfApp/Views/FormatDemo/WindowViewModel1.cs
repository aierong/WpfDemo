using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.Views.FormatDemo
{
    public class WindowViewModel1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public WindowViewModel1 ()
        {
            ShowCommand = new MyCommand( Show );
        }

        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }



        public void Show ()
        {
            Name = "Guo";
            Price = 1.23456789M;

            //MessageBox.Show( "show Command" );
        }

        private DateTime nowtime = DateTime.Now;

        public DateTime NowTime
        {
            get
            {
                return nowtime;
            }
            set
            {
                nowtime = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "NowTime" ) );
            }
        }


        private decimal price = 123.456789M;


        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Price" ) );
            }
        }

        private string name = "cheng";

        /// <summary>
        /// 名字
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
            }
        }

        private string lastname = "guo";

        /// <summary>
        /// 名字
        /// </summary>
        public string LastName
        {
            get
            {

                return lastname;
            }
            set
            {
                lastname = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "LastName" ) );
            }
        }
    }
}
