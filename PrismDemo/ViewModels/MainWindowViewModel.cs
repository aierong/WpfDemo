using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismDemo.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {
        private string _text="init";

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                SetProperty( ref _text , value );
            }
        }

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
