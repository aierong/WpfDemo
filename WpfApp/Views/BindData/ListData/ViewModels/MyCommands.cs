using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.BindData.ListData.ViewModels
{
    public class MyCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action execAction;


        public MyCommands ( Action action )
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
