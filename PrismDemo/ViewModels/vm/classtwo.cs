using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;



namespace PrismDemo.ViewModels.vm
{
    public class classtwo : BindableBase
    {
        private string _texts = "initclasstwo";

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
