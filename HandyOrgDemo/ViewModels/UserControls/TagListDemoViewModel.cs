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


        public ObservableCollection<string> ManList
        {
            get; set;
        } = new ObservableCollection<string>();

        public TagListDemoViewModel ()
        {
            Students = new ObservableCollection<Student>()
            {
                new Student(){ Id=1, Age=11, Name="a(哈哈无法删除)" ,ShowCloseButton=false},
                new Student(){ Id=2, Age=12, Name="a2" ,ShowCloseButton=true},
                new Student(){ Id=3, Age=13, Name="A#3" ,ShowCloseButton=true}
            };

            ManList = new ObservableCollection<string>()
            {
                "I",
                "guoguo"
            };
        }

        [RelayCommand]
        void Add ()
        {
            var i = Students.Count >= 1 ? Students.Max( item => item.Id + 1 ) : 1;

            Students.Add( new Student()
            {
                ShowCloseButton = true ,
                Id = i ,
                Age = 18 ,
                Name = "guoguo" + i.ToString()
            } );

            ManList.Add("qq");
        }



    }
}
