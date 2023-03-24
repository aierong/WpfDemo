using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfDemoNet6.IOCDemo.Service.Service;

namespace WpfDemoNet6.IOCDemo.ViewModels
{
    public partial class WindowViewModel1 : ObservableObject
    {
        private IBill _IBill;
        public WindowViewModel1 ( IBill iBill )
        {
            this._IBill = iBill;
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

            if ( this._IBill.IsExistId( Title ) )
            {
                Title = "qq" + this._IBill.GetData( Title );
            }
            else
            {
                Title = "qq";
            }
        }

        bool CanButton ()
        {
            return IsEnabled;
        }




    }
}
