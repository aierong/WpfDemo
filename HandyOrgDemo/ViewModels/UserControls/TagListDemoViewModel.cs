using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyOrgDemo.Models;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class TagListDemoViewModel : ObservableObject
    {


        public ObservableCollection<Student> Students
        {
            get; set;
        } = new ObservableCollection<Student>();

        public TagListDemoViewModel ()
        {
            Students = new ObservableCollection<Student>()
            {
                new Student(){ Id=1, Age=11, Name="a1" },
                new Student(){ Id=2, Age=12, Name="a2" },
                new Student(){ Id=3, Age=13, Name="A#3" }
            };
        }

        [RelayCommand]
        void Add ()
        {


            Students.Add( new Student()
            {
                Id = Students.Count >= 1 ? Students.Max( item => item.Id + 1 ) : 1 ,
                Age = 18 ,
                Name = "guoguo"
            } );


        }



    }
}
