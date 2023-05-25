using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PrismDemo.LoginDemo.Demo2
{
    public class UCLoginViewModel : BindableBase, IDialogAware
    {
         
        private string _title = "请登录";
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
            //throw new NotImplementedException();
        }

        public void OnDialogOpened ( IDialogParameters parameters )
        {
            //throw new NotImplementedException();
        }



        public UCLoginViewModel()
        {
            
        }



        private DelegateCommand _LoginClickCommand;
        /// <summary>
        /// 登录操作
        /// </summary>
        public DelegateCommand LoginClickCommand => _LoginClickCommand ?? ( _LoginClickCommand = new DelegateCommand( () =>
        {

            // 这里写验证逻辑
            bool isvalid = true;

            if ( isvalid )
            {
                DialogParameters _Parameters = new DialogParameters( "userid=123&username=qq" );
                //弹窗返回值
                RequestClose?.Invoke( new DialogResult( ButtonResult.OK , _Parameters ) );
            }
             
        } ) );



        private DelegateCommand _CancelClickCommand;
        /// <summary>
        /// 登录操作
        /// </summary>
        public DelegateCommand CancelClickCommand => _CancelClickCommand ?? ( _CancelClickCommand = new DelegateCommand( () =>
        {

            //  
            RequestClose?.Invoke( new DialogResult( ButtonResult.Cancel ) );

        } ) );



    }
}
