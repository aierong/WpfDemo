using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommunityToolkitMvvmDemo.ViewModels
{
    public partial class mainpageViewModel : ObservableObject
    {
        /// <summary>
        /// sql文本
        /// </summary>
        [ObservableProperty]
        private string sqlTxt = "init";


    }
}
