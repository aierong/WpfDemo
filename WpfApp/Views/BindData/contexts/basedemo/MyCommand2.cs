using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.BindData.contexts.basedemo
{
    public class MyCommand2 : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action execAction;


        public MyCommand2 ( Action action )
        {
            execAction = action;
        }

        public bool CanExecute ( object parameter )
        {
            return true;
        }

        public void Execute ( object parameter )
        {
            execAction();
        }
    }
}
