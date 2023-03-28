using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.BindData.ListData.Models;

namespace WpfApp.Views.BindData.ListData.ViewModels
{
    public class ListDataViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Student> Students
        {
            get; set;
        }

        public ListDataViewModel ()
        {
            //初始化
            Students = new ObservableCollection<Student>() {
                new Student(){ Id=1, Age=11, Name="Tom"},
                new Student(){ Id=2, Age=12, Name="Darren"},
                new Student(){ Id=3, Age=13, Name="Jacky"},
                new Student(){ Id=4, Age=14, Name="Andy"}
            };


            //在添加、删除或移动项或刷新整个列表时发生。
            Students.CollectionChanged += ( object sender , System.Collections.Specialized.NotifyCollectionChangedEventArgs e ) =>
            {
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
            };

            UpdateCommand = new MyCommands( () =>
           {
               if ( Students.Count >= 2 )
               {
                   Students.RemoveAt( 0 );
                   Students.RemoveAt( 0 );
               }

               Students.Add( new Student() { Id = Students.Count >= 1 ? Students.Max( item => item.Id + 1 ) : 1 , Age = 18 , Name = "guoguo" } );


               //通知数据已经变化  这里可以不写了,因为注册了事件CollectionChanged
               //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
           } );

            AllUpdateCommand = new MyCommands( () =>
            {
                Students = new ObservableCollection<Student>() {
                new Student(){ Id=111, Age=11, Name="Tom"},
                new Student(){ Id=222, Age=12, Name="Darren"},
                new Student(){ Id=333, Age=13, Name="Jacky"},
                new Student(){ Id=444, Age=14, Name="Andy"}
                 };


                //通知数据已经变化 这里可以不写了,因为注册了事件CollectionChanged
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
            } );
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



        /// <summary>
        /// 命令
        /// </summary>
        public MyCommands UpdateCommand
        {
            get; set;
        }


        public MyCommands AllUpdateCommand
        {
            get; set;
        }




        /// <summary>
        /// 描述
        /// </summary>
        public int Total
        {
            get => Students != null & Students.Count > 0 ? Students.Sum( item => item.Age ) : 0;

        }






        //private void Students_CollectionChanged ( object sender , System.Collections.Specialized.NotifyCollectionChangedEventArgs e )
        //{
        //    PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
        //}
    }
}
