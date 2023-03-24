using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfDemoNet6.IOCDemo.ViewModels
{
    public partial class WindowViewModel1 : ObservableObject
    {
        public WindowViewModel1 ()
        {

        }

        [ObservableProperty]
        private string title = "hello";


        [ObservableProperty]
        [NotifyCanExecuteChangedFor( nameof( ButtonClickCommand ) )]
        private bool isEnabled = false;


        [RelayCommand( CanExecute = nameof( CanButton ) )]
        void ButtonClick ()
        {
            //点击按钮,修改标题
            Title = "hello(改)";
        }

        bool CanButton ()
        {
            return IsEnabled;
        }




    }
}
