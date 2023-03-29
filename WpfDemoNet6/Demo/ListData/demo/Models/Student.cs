using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfDemoNet6.Demo.ListData.demo.Models
{
    public partial class Student : ObservableObject
    {
        public int Id
        {
            get; set;
        }

        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private int age = 0;
    }
}
