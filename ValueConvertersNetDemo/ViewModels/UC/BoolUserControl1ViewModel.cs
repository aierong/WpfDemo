using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;


namespace ValueConvertersNetDemo.ViewModels.UC
{
    public class BoolUserControl1ViewModel : BindableBase
    {

        private bool _IsOk = false;

        public bool IsOk
        {
            get
            {
                return _IsOk;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _IsOk , value );
            }
        }



        private DelegateCommand _QieHuanClickCommand;
        public DelegateCommand QieHuanClickCommand => _QieHuanClickCommand ?? ( _QieHuanClickCommand = new DelegateCommand( () =>
        {
            this.IsOk = !this.IsOk;
        } ) );


    }
}
