using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkitMvvmDemo.Models;

namespace CommunityToolkitMvvmDemo.ViewModels.UC
{
    public partial class StudentListViewModel : ObservableObject
    {
        public ObservableCollection<Student> Students
        {
            get;
        } = new ObservableCollection<Student>() { };



    }
}
