using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.MyVm
{
    public class WinOneVM : BindableBase
    {
        private string _texts = "init———vm";

        public string TextS
        {
            get
            {
                return _texts;
            }
            set
            {
                SetProperty( ref _texts , value );
            }
        }

        private string _textabc = "vm";

        public string TextABC
        {
            get
            {
                return _textabc;
            }
            set
            {
                SetProperty( ref _textabc , value );
            }
        }
    }
}
