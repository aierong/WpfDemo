using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.MyVm.ModuleABC
{
    public class UserDataVM : BindableBase
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

        private string _nameabc = "guoguo";

        public string NameABC
        {
            get
            {
                return _nameabc;
            }
            set
            {
                SetProperty( ref _nameabc , value );
            }
        }
    }
}
