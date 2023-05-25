using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;

namespace PrismDemo.LoginDemo.Demo1
{
    public class LoginWindowViewModel : BindableBase
    {
        IContainerExtension containerExtension;

        public LoginWindowViewModel ( IContainerExtension _containerExtension )
        {
            this.containerExtension = _containerExtension;
        }




        private DelegateCommand _LoginClickCommand;
        /// <summary>
        /// 登录操作
        /// </summary>
        public DelegateCommand LoginClickCommand => _LoginClickCommand ?? ( _LoginClickCommand = new DelegateCommand( () =>
        {

            //获取当前的主窗体
            var main = Application.Current.MainWindow;
            var windows = this.containerExtension.Resolve<MainPage>();

            //重现设置主窗体
            Application.Current.MainWindow = windows;

            windows.Show();
            main.Close();

        } ) );







    }
}
