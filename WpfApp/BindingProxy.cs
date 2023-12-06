using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// 万能绑定：https://github.com/Kinnara/ModernWpf/blob/master/ModernWpf/Controls/Primitives/BindingProxy.cs
// 使用：https://thomaslevesque.com/2011/03/21/wpf-how-to-bind-to-data-when-the-datacontext-is-not-inherited/


namespace WpfApp
{
    public class BindingProxy : Freezable
    {
        #region Value

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof( Value ) ,
                typeof( object ) ,
                typeof( BindingProxy ) );

        public object Value
        {
            get => GetValue( ValueProperty );
            set => SetValue( ValueProperty , value );
        }

        #endregion



        protected override Freezable CreateInstanceCore ()
        {
            return new BindingProxy();
        }
    }
}
