using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class LoadingViewModel : ObservableObject
    {
        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮 

            //Debug.WriteLine( "ButtonClick" );

            IsRun = !IsRun;
        }


        [ObservableProperty]
        private bool isRun = false;




    }
}
