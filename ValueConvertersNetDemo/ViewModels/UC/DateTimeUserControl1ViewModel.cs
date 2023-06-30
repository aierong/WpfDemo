using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;



namespace ValueConvertersNetDemo.ViewModels.UC
{
    public class DateTimeUserControl1ViewModel : BindableBase
    {
        private DateTime _ChangeDate = DateTime.Now;

        public DateTime ChangeDate
        {
            get
            {
                return _ChangeDate;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _ChangeDate , value );
            }
        }

        private DelegateCommand _QieHuanClickCommand;
        public DelegateCommand QieHuanClickCommand => _QieHuanClickCommand ?? ( _QieHuanClickCommand = new DelegateCommand( () =>
        {
            this.ChangeDate = DateTime.Now;
        } ) );

    }
}
