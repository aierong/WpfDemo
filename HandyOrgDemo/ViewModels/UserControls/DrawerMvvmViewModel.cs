using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Data;
using HandyOrgDemo.Models;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class DrawerMvvmViewModel : ObservableObject
    {
        [RelayCommand()]
        void LeftButtonClick ()
        {
            //点击按钮 

            IsLeftOpen = true;
        }



        [RelayCommand()]
        void TopButtonClick ()
        {
            //点击按钮 

            IsTopOpen = true;
        }

        [ObservableProperty]
        private bool isLeftOpen = false;

        [ObservableProperty]
        private bool isTopOpen = false;


        [RelayCommand()]
        void LeftCloseButtonClick ()
        {
            //点击按钮 

            IsLeftOpen = false;
        }

        public DrawerMvvmViewModel ()
        {

        }
    }
}
