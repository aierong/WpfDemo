using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;



namespace PrismDemo.ViewModels.v2
{
    public class Class2 : BindableBase
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
    }
}
