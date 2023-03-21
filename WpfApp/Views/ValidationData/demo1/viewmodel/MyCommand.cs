using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.ValidationData.demo1.viewmodel
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action execAction;
        Func<bool> canexecAction;

        public MyCommand ( Action action , Func<bool> canexecAction )
        {
            execAction = action;
            this.canexecAction = canexecAction;
        }

        public bool CanExecute ( object parameter )
        {
            return canexecAction();
        }

        public void Execute ( object parameter )
        {
            execAction();
        }
    }
}
