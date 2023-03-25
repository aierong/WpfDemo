using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.FormatDemo
{
    public class WindowViewModel1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private decimal  price;


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

        private string name;

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

        private string lastname;

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
