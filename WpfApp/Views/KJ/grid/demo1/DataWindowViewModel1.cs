using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

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
                new Student(){ Id=1, Age=11, Name="Tom" ,IsMan =true  },
                new Student(){ Id=2, Age=12, Name="Darren" ,IsMan =true},
                new Student(){ Id=3, Age=13, Name="Jacky" ,IsMan =false },
                new Student(){ Id=4, Age=14, Name="Andy",IsMan =false}
            };

            UpdateCommand = new MyCommands( () =>
            {
                Debug.WriteLine( "111" );

                MessageBox.Show( "修改" );
            } );

            DeleteCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( stu );

                MessageBox.Show( "del" + stu.Id );
            } );


            SelectionChangedCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "SelectionChangedCommand" );

                Debug.WriteLine( stu.Id );
            } );

            SelectionsChangedCommand = new MyParCommand<System.Collections.IList>( ( System.Collections.IList selectList ) =>
            {
                 
                //多选
                Debug.WriteLine( string.Format( "SelectionsChangedCommand,选择了{0}条记录" , selectList.Count ) );

                foreach ( Student item in selectList )
                {
                    Debug.WriteLine( item.Id );
                }

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

        public MyParCommand<Student> SelectionChangedCommand
        {
            get; set;
        }

        public MyParCommand<System.Collections.IList> SelectionsChangedCommand
        {
            get; set;
        }
    }
}
