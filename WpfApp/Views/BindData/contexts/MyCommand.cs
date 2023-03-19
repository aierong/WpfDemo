using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

//命令需要实现接口:ICommand

namespace WpfApp.Views.BindData.contexts
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action execAction;


        public MyCommand ( Action action )
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
