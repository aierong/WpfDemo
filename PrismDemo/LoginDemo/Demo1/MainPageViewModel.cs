using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.LoginDemo.Demo1
{
    public class MainPageViewModel : BindableBase
    {
        private string _TextTitle = "init—vm";

        public string TextTitle
        {
            get
            {
                return _TextTitle;
            }
            set
            {
                SetProperty( ref _TextTitle , value );
            }
        }


        public MainPageViewModel()
        {
            TextTitle = "bt";
        }


    }
}
