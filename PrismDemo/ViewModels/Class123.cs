using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.ViewModels
{
    public  class Class123 : BindableBase
    {
        private string _texts = "init123";

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


        private string _texta = "inita";

        public string TextA
        {
            get
            {
                return _texta;
            }
            set
            {
                SetProperty( ref _texta , value );
            }
        }
    }
}
