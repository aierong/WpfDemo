using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HandyOrgDemo.Models
{
    public class Student
    {
        public int Id
        {
            get; set;
        }

        public bool IsSelected
        {
            get; set;
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
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
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
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Age" ) );
            }
        }



        public override string ToString ()
        {
            return Name;
        }

    }
}
