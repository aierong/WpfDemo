using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfDemoNet6.Demo.ListData.plus.Models;

namespace WpfDemoNet6.Demo.ListData.plus.ViewModels
{
    public partial  class EmpListViewModel : ObservableObject
    {
        public BindingList<Emp> Students
        {
            get; set;
        } = new BindingList<Emp>();



        public EmpListViewModel()
        {
            //初始化
            Students = new BindingList<Emp>() {
                new Emp(){ Id=1, Age=11, Name="Tom"},
                new Emp(){ Id=2, Age=12, Name="Darren"},
                new Emp(){ Id=3, Age=13, Name="Jacky"},
                new Emp(){ Id=4, Age=14, Name="Andy"}
            };

            // ListChanged 事件 当列表或列表中的项更改时发生。
            Students.ListChanged += ( object? sender , ListChangedEventArgs e ) =>
            {
                //e 这个参数里面有很多有用数据,可以判断类型等等

                //通知总计变化了
                OnPropertyChanged( nameof( Total ) );
            };

        }

        /// <summary>
        /// 总计
        /// </summary>
        public int Total
        {
            get => Students != null && Students.Count > 0 ? Students.Sum( item => item.Age ) : 0;
        }

        [RelayCommand]
        void Update ()
        {
            if ( Students.Count >= 2 )
            {
                Students.RemoveAt( 0 );
                Students.RemoveAt( 0 );
            }

            Students.Add( new Emp() { Id = Students.Count >= 1 ? Students.Max( item => item.Id + 1 ) : 1 , Age = 18 , Name = "guoguo" } );

            //修改最后一项数据
            //必须重新 new一个新对象
            Students[Students.Count - 1] = new Emp() { Id = 2222222 , Age = 8 , Name = "guoguo2" };


            //通知数据已经变化  这里可以不写了,因为注册了事件ListChanged
        }

        [RelayCommand]
        void AllUpdate ()
        {
            // 这样直接赋值,UI无法感知变化的
            //Students = new ObservableCollection<Student>() {
            //new Student(){ Id=111, Age=11, Name="Tom"},
            //new Student(){ Id=222, Age=12, Name="Darren"},
            //new Student(){ Id=333, Age=13, Name="Jacky"},
            //new Student(){ Id=444, Age=14, Name="Andy"}
            // };

            //只有删除全部,再一个个添加
            Students.Clear();
            Students.Add( new Emp() { Id = 1111 , Age = 18 , Name = "guoguo1" } );
            Students.Add( new Emp() { Id = 2222 , Age = 28 , Name = "guoguo2" } );


            //通知数据已经变化 这里可以不写了,因为注册了事件ListChanged
        }

        [RelayCommand]
        void UpdateOne ()
        {
            if ( Students.Count > 0 )
            {
                //修改某一个记录  如果是单独修改某一个元素的某个属性，需要Student类型也要继承INotifyPropertyChanged
                Students[0].Age = Students[0].Age + 1;
                Students[0].Name = Students[0].Name + "_GAI";
                //特别注意:Id没有实现,属性通知,所以ui就不知道其改变的
                Students[0].Id = Students[0].Id + 1111;

                //通知数据已经变化  ,这里可以不写了,因为注册了事件ListChanged
                //OnPropertyChanged( nameof( Total ) );
            }
        }

    }
}
