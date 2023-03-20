using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.UserControlDemo.zhonghedemo.UCUserControl
{
    public class TopCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action execAction;


        public TopCommand ( Action action )
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
