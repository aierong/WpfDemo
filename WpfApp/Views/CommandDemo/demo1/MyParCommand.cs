using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.CommandDemo.demo1
{
    public class MyParCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<T> execActionpar;

        public MyParCommand ( Action<T> action )
        {

            execActionpar = action;
        }

        public bool CanExecute ( object parameter )
        {
            return true;
        }

        public void Execute ( object parameter )
        {
            execActionpar( ( T ) parameter );
        }
    }
}
