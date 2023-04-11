using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;



namespace PrismDemo.ViewModels.v1
{
    public class TestWindowViewModel : BindableBase
    {
        private string _texts = "inits";

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
