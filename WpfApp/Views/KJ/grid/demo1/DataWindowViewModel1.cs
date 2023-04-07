using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using WpfApp.Views.KJ.grid.demo1.Models;
using WpfApp.Views.KJ.Base;

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
                new Student(){ Id=4, Age=14, Name="Andy",IsMan =false},
                new Student(){ Id=5, Age=15, Name="WUBingBing",IsMan =true},
                new Student(){ Id=6, Age=16, Name="KT",IsMan =false},
                new Student(){ Id=7, Age=17, Name="KT17",IsMan =false},
                new Student(){ Id=8, Age=18, Name="WUBing",IsMan =true},
                new Student(){ Id=9, Age=19, Name="Yang",IsMan =true}
            };

            UpdateCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "UpdateCommand 修改" );

                MessageBox.Show( "修改" );
            } );

            SelectRowsCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "SelectRowsCommand  " );

                foreach ( Student item in Students )
                {
					//给IsSelectRow赋值，前端页面就会选择上
                    item.IsSelectRow = item.IsMan && item.Age >= 12;
                }
            } );

            DeleteCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "DeleteCommand 删除" );

                MessageBox.Show( "del" + stu.Id );
            } );

            SQCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "SQCommand 申请" );

                MessageBox.Show( "申请:" + stu.Id );
            } );

            BYCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "BYCommand" );

                MessageBox.Show( "毕业:" + stu.Id );
            } );

            //单选的
            SelectionChangedCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "SelectionChangedCommand 单选的" );

                Debug.WriteLine( stu.Id );
            } );

            //多选
            SelectionsChangedCommand = new MyParCommand<System.Collections.IList>( ( System.Collections.IList selectList ) =>
            {
                //多选
                Debug.WriteLine( string.Format( "SelectionsChangedCommand 多选,选择了{0}条记录" , selectList.Count ) );

                foreach ( Student item in selectList )
                {
                    Debug.WriteLine( item.Id );
                }

            } );

            //鼠标双击  
            DoubleClickCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "DoubleClickCommand 鼠标双击" );

                Debug.WriteLine( stu.Id );
            } );

            //获取选择行(单选)
            SelectCommand = new MyParCommand<Student>( ( Student stu ) =>
            {
                Debug.WriteLine( "SelectCommand 获取选择行(单选)" );

                if ( stu != null )
                {
                    Debug.WriteLine( stu.Id );
                }



            } );

            SelectsCommand = new MyParCommand<System.Collections.IList>( ( System.Collections.IList selectList ) =>
            {
                //多选
                Debug.WriteLine( string.Format( "SelectsCommand 多选,选择了{0}条记录" , selectList.Count ) );

                if ( selectList != null )
                {
                    if ( selectList.Count > 0 )
                    {
                        foreach ( Student item in selectList )
                        {
                            Debug.WriteLine( item.Id );
                        }
                    }
                }

            } );
        }

        public MyCommand SelectRowsCommand
        {
            get; set;
        }

        public MyCommand UpdateCommand
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

        public MyParCommand<Student> SQCommand
        {
            get; set;
        }

        public MyParCommand<Student> BYCommand
        {
            get; set;
        }

        public MyParCommand<System.Collections.IList> SelectionsChangedCommand
        {
            get; set;
        }


        public MyParCommand<Student> DoubleClickCommand
        {
            get; set;
        }


        public MyParCommand<Student> SelectCommand
        {
            get; set;
        }

        public MyParCommand<System.Collections.IList> SelectsCommand
        {
            get; set;
        }
    }
}
