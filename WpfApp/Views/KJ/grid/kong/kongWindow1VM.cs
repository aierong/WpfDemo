using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.BaseCommand;
using WpfApp.Views.KJ.grid.kong.Models;

namespace WpfApp.Views.KJ.grid.kong
{
    public class kongWindow1VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Student> Students
        {
            get; set;
        } = new ObservableCollection<Student>();

        public bool _HasItems = true;
        public bool HasItems
        {
            get
            {
                return _HasItems;
            }
            set
            {
                _HasItems = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "HasItems" ) );
            }
        }

        public kongWindow1VM ()
        {
            //初始化
            Students = new ObservableCollection<Student>() {
                new Student(){ Id=1, Age=11, Name="Tom" ,IsMan =true  },
                new Student(){ Id=2, Age=12, Name="Darren" ,IsMan =true},
                new Student(){ Id=3, Age=13, Name="Jacky" ,IsMan =false },

            };

            HasItems = true;

            UpdateCommand = new MyCommand( () =>
            {

                if ( HasItems )
                {
                    Students.Clear();
                }
                else
                {
                    Students.Add( new Student() { Id = 1 , Age = 11 , Name = "Tom" , IsMan = true } );
                }

                HasItems = !HasItems;
            } );
        }

        public MyCommand UpdateCommand
        {
            get; set;
        }
    }
}
