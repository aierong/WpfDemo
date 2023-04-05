using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WpfApp.Views.KJ.grid.demo1.Models
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get; set;
        }

        private bool _isselectrow;

        public bool IsSelectRow
        {
            get
            {
                return _isselectrow;
            }
            set
            {
                _isselectrow = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "IsSelectRow" ) );
            }
        }

        private bool _isman;

        public bool IsMan
        {
            get
            {
                return _isman;
            }
            set
            {
                _isman = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "IsMan" ) );
            }
        }


        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Age" ) );
            }
        }


    }
}
