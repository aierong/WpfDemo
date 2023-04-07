using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



namespace WpfApp.Views.BaseCommand
{
    public class MyParCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<T> execAction;
        Func<T , bool> _canExecuteMethod = null;


        public MyParCommand ( Action<T> action ) : this( action , null )
        {

        }

        public MyParCommand ( Action<T> action , Func<T , bool> canExecuteMethod )
        {
            execAction = action;
            _canExecuteMethod = canExecuteMethod;
        }

        public bool CanExecute ( object parameter )
        {
            if ( _canExecuteMethod != null )
            {
                return _canExecuteMethod( ( T ) parameter );
            }
            return true;
        }

        public void Execute ( object parameter )
        {
            if ( execAction != null )
            {
                execAction( ( T ) parameter );
            }

        }
    }
}
