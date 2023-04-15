using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismDemo.DialogDemo.Models;

namespace PrismDemo.DialogDemo.Dialogs
{
    public class UserDialogViewModel : BindableBase, IDialogAware
    {
        private string _title = "Notification";
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetProperty( ref _title , value );
            }
        }

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog ()
        {
            return true;
        }

        public void OnDialogClosed ()
        {

        }

        public void OnDialogOpened ( IDialogParameters parameters )
        {
            //这里接收参数

            //判断一下,是否存在
            if ( parameters.ContainsKey( "p1" ) )
            {
                var val = parameters.GetValue<string>( "p1" );
            }

            if ( parameters.ContainsKey( "pobj" ) )
            {
                var obj = parameters.GetValue<People>( "pobj" );

                Message = string.Format( "Name:{0} Address:{1}" , obj.Name , obj.Address );
            }

            //可以修改一下标题
            Title = "我的标题";
        }

        private string _message = "";
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                SetProperty( ref _message , value );
            }
        }


        private string _Name = string.Empty;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                SetProperty( ref _Name , value );
            }
        }

        private string _Address = string.Empty;

        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                SetProperty( ref _Address , value );
            }
        }

        public DelegateCommand SaveClickCommand
        {
            get; private set;
        }

        public DelegateCommand CancelClickCommand
        {
            get; private set;
        }

        public UserDialogViewModel()
        {
            //确定操作
            SaveClickCommand = new DelegateCommand( () =>
            {

                DialogParameters pars = new DialogParameters();
                pars.Add( "Result1" , "qq" );
                //返回一个对象过去
                pars.Add( "Result1obj" , new People()
                {
                    Name = this.Name ,
                    Address = this.Address
                } );

                //DialogResult第1个参数是返回状态,第2个参数是返回的值(如果没有也可以不带参数)
                RequestClose?.Invoke( new DialogResult( ButtonResult.OK, pars ) );
            } );

            //取消操作
            CancelClickCommand = new DelegateCommand( () =>
            {
                RequestClose?.Invoke( new DialogResult( ButtonResult.Cancel ) );
            } );
        }
    }
}
