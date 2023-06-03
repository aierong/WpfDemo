using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace WpfDemoNet6.IOCDemo.ViewModels
{
    public partial class WindowViewModel1 : ObservableObject
    {
        readonly Service.Service.IBill _IBill;


        public WindowViewModel1 ( Service.Service.IBill iBill )
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


            ////我们也可以这样,调用
            //var ser = App.Current.Services.GetService<IOCDemo.Service.Service.IBill>();
            //var str1 = ser?.GetData( "app" );
        }

        bool CanButton ()
        {
            return IsEnabled;
        }




    }
}
