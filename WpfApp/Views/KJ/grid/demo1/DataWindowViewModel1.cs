using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.KJ.grid.demo1
{
    public class DataWindowViewModel1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Student> Students
        {
            get; set;
        } = new ObservableCollection<Student>();


        public DataWindowViewModel1 ()
        {
            //初始化
            Students = new ObservableCollection<Student>() {
                new Student(){ Id=1, Age=11, Name="Tom"},
                new Student(){ Id=2, Age=12, Name="Darren"},
                new Student(){ Id=3, Age=13, Name="Jacky"},
                new Student(){ Id=4, Age=14, Name="Andy"}
            };

            UpdateCommand = new MyCommands( () =>
            {
                Debug.WriteLine( "111" );
            } );

            DeleteCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( stu );
            } );
        }

        public MyCommands UpdateCommand
        {
            get; set;
        }


        public MyParCommand<Student> DeleteCommand
        {
            get; set;
        }


    }
}
