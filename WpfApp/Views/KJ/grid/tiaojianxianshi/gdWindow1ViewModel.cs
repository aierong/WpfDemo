using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.KJ.grid.tiaojianxianshi
{
    public class gdWindow1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<StudentDataNew> Students
        {
            get; set;
        } = new ObservableCollection<StudentDataNew>();

        public gdWindow1ViewModel ()
        {
            //初始化
            Students = new ObservableCollection<StudentDataNew>() {
                new StudentDataNew(){ Id=1, Age=11, Name="Tom" ,IsMan =true  },
                new StudentDataNew(){ Id=2, Age=12, Name="Darren" ,IsMan =true},
                new StudentDataNew(){ Id=3, Age=13, Name="Jacky" ,IsMan =false },
                new StudentDataNew(){ Id=4, Age=14, Name="Andy",IsMan =false},
                new StudentDataNew(){ Id=5, Age=15, Name="WUBingBing",IsMan =true},
                new StudentDataNew(){ Id=6, Age=16, Name="KT",IsMan =false},
                new StudentDataNew(){ Id=7, Age=17, Name="KT17",IsMan =false},
                new StudentDataNew(){ Id=8, Age=18, Name="WUBing",IsMan =true},
                new StudentDataNew(){ Id=9, Age=19, Name="Yang",IsMan =true}
            };

        }
    }
}
