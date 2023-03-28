using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BindData.ListData.Models;

namespace WpfApp.Views.BindData.ListData.ViewModels
{
    public class ListDataViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Student> Students
        {
            get;
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

            Name = "Init";
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

    }
}
