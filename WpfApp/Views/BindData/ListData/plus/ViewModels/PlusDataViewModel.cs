using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BindData.ListData.plus.Models;


namespace WpfApp.Views.BindData.ListData.plus.ViewModels
{
    public class PlusDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public BindingList<EMP> Students
        {
            get; set;
        } = new BindingList<EMP>();

        public PlusDataViewModel ()
        {
            //初始化
            Students = new BindingList<EMP>() {
                new EMP(){ Id=10, Age=10, Name="Tom"},
                new EMP(){ Id=20, Age=11, Name="Darren"},
                new EMP(){ Id=30, Age=12, Name="Jacky"},
                new EMP(){ Id=40, Age=13, Name="Andy"},
                new EMP(){ Id=50, Age=18, Name="guoguo"}
            };

            // ListChanged 事件 当列表或列表中的项更改时发生。
            Students.ListChanged += ( object sender , ListChangedEventArgs e ) =>
            {
                //e 这个参数里面有很多有用数据,可以判断类型等等

                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
            };

            UpdateCommand = new CZCommand( () =>
            {
                if ( Students.Count >= 2 )
                {
                    Students.RemoveAt( 0 );
                    Students.RemoveAt( 0 );
                }

                Students.Add( new EMP() { Id = Students.Count >= 1 ? Students.Max( item => item.Id + 1 ) : 1 , Age = 18 , Name = "guoguo" } );

                //修改最后一项数据
                //  new一个新对象
                Students[Students.Count - 1] = new EMP() { Id = 2222222 , Age = 8 , Name = "guoguo2" };

                ////通知数据已经变化  ,ListChanged 事件已经实现
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
            } );

            AllUpdateCommand = new CZCommand( () =>
            {
                //这样直接赋值,UI无法感知变化的
                //Students = new BindingList<EMP>() {
                //new EMP(){ Id=111, Age=11, Name="Tom"},
                //new EMP(){ Id=222, Age=12, Name="Darren"},
                //new EMP(){ Id=333, Age=13, Name="Jacky"},
                //new EMP(){ Id=444, Age=14, Name="Andy"}
                // };

                //只有删除全部,再一个个添加
                Students.Clear();
                Students.Add( new EMP() { Id = 1111 , Age = 18 , Name = "guoguo1" } );
                Students.Add( new EMP() { Id = 2222 , Age = 28 , Name = "guoguo2" } );

                ////通知数据已经变化  ,ListChanged 事件已经实现
                //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
            } );


            UpdateOneCommand = new CZCommand( () =>
            {
                if ( Students.Count > 0 )
                {
                    //修改某一个记录
                    Students[0].Age = Students[0].Age + 1;
                    Students[0].Name = Students[0].Name + "_GAI";
                    //特别注意:Id没有实现,属性通知,所以ui就不知道其改变的
                    Students[0].Id = Students[0].Id + 1111;

                    ////通知数据已经变化  ,ListChanged 事件已经实现
                    //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Total" ) );
                }
            } );

        }


        public CZCommand UpdateCommand
        {
            get; set;
        }


        public CZCommand AllUpdateCommand
        {
            get; set;
        }


        public CZCommand UpdateOneCommand
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


    }
}
