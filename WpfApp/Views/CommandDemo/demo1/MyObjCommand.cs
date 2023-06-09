﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.Views.CommandDemo.demo1
{
    public  class MyObjCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> execAction;


        public MyObjCommand ( Action<object> action )
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
