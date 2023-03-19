using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.CommandDemo.demo1
{
    public  class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> execAction;


        public MyCommand ( Action<object> action )
        {
            execAction = action;
        }

        public bool CanExecute ( object parameter )
        {
            return true;
        }

        public void Execute ( object parameter )
        {
            execAction( parameter );
        }
    }
}
