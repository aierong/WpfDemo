using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;



namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class UserControlAnimationPathViewModel : ObservableObject
    {

        public UserControlAnimationPathViewModel ()
        {

        }


        [RelayCommand()]
        void TopButtonClick ()
        {
            //点击按钮 

            IsOpen = !IsOpen;
        }

        [ObservableProperty]
        private bool isOpen = false;


    }
}
