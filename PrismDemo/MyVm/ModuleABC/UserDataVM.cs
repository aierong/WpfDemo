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
        private string _TextABC = "init—vm";

        public string TextABC
        {
            get
            {
                return _TextABC;
            }
            set
            {
                SetProperty( ref _TextABC , value );
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
