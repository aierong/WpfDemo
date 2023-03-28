﻿using System;
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



            //修改列表中数据,删除几个,再添加
            UpdateCommand = new MyCommands( () =>
           {
               if ( Students.Count >= 2 )
               {
                   Students.RemoveAt( 0 );
                   Students.RemoveAt( 0 );
               }

               Students.Add( new Student() { Id = Students.Count >= 1 ? Students.Max( item => item.Id + 1 ) : 1 , Age = 18 , Name = "guoguo" } );

               //修改最后一项数据
               //必须重新 new一个新对象
               Students[Students.Count - 1] = new Student() { Id = 2222222 , Age = 8 , Name = "guoguo2" };


               //通知数据已经变化  这里可以不写了,因为注册了事件CollectionChanged
               //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
           } );

            AllUpdateCommand = new MyCommands( () =>
            {
                //这样直接赋值,UI无法感知变化的
                //Students = new ObservableCollection<Student>() {
                //new Student(){ Id=111, Age=11, Name="Tom"},
                //new Student(){ Id=222, Age=12, Name="Darren"},
                //new Student(){ Id=333, Age=13, Name="Jacky"},
                //new Student(){ Id=444, Age=14, Name="Andy"}
                // };

                //只有删除全部,再一个个添加
                Students.Clear();
                Students.Add( new Student() { Id = 1111 , Age = 18 , Name = "guoguo1" } );
                Students.Add( new Student() { Id = 2222 , Age = 28 , Name = "guoguo2" } );

                
                //通知数据已经变化 这里可以不写了,因为注册了事件CollectionChanged
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
            } );

            UpdateOneCommand = new MyCommands( () =>
            {
                if ( Students.Count > 0 )
                {
                    //修改某一个记录
                    Students[0].Age = Students[0].Age + 1;
                    Students[0].Name = Students[0].Name + "_GAI";
                    //特别注意:Id没有实现,属性通知,所以ui就不知道其改变的
                    Students[0].Id = Students[0].Id + 1111;



                    //通知数据已经变化  ,CollectionChanged在单独修改某个项的属性时是不会触发的
                    PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
                }
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




        public MyCommands UpdateCommand
        {
            get; set;
        }


        public MyCommands AllUpdateCommand
        {
            get; set;
        }


        public MyCommands UpdateOneCommand
        {
            get; set;
        }


        /// <summary>
        /// 总计
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
