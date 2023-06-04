using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.KJ.grid.tiaojianxianshi
{
    public class gridWindow1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<StudentData> Students
        {
            get; set;
        } = new ObservableCollection<StudentData>();

        public gridWindow1ViewModel ()
        {
            //初始化
            Students = new ObservableCollection<StudentData>() {
                new StudentData(){ Id=1, Age=11, Name="Tom" ,IsMan =true  },
                new StudentData(){ Id=2, Age=12, Name="Darren" ,IsMan =true},
                new StudentData(){ Id=3, Age=13, Name="Jacky" ,IsMan =false },
                new StudentData(){ Id=4, Age=14, Name="Andy",IsMan =false},
                new StudentData(){ Id=5, Age=15, Name="WUBingBing",IsMan =true},
                new StudentData(){ Id=6, Age=16, Name="KT",IsMan =false},
                new StudentData(){ Id=7, Age=17, Name="KT17",IsMan =false},
                new StudentData(){ Id=8, Age=18, Name="WUBing",IsMan =true},
                new StudentData(){ Id=9, Age=19, Name="Yang",IsMan =true}
            };

        }
    }
}
