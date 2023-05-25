using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.LoginDemo.Demo2
{
    public  class MainIndexViewModel : BindableBase
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

        public MainIndexViewModel()
        {
            TextTitle = "主窗体";
        }
    }
}
