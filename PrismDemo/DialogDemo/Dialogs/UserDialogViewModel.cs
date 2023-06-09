﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismDemo.DialogDemo.Models;


/*
IDialogAware接口说明:

CanCloseDialog()函数是决定窗体是否关闭
OnDialogClosed()函数是窗体关闭时触发，触发条件取决于CanCloseDialog()函数
OnDialogOpened()函数时窗体打开时触发，比窗体Loaded事件早触发(这个函数中可以接收参数)
Title为窗体的标题
RequestClose为关闭事件，可由此控制窗体的关闭
*/

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
                var val1 = parameters.GetValue<string>( "p1" );
            }

            if ( parameters.ContainsKey( "p2" ) )
            {
                var val2 = parameters.GetValue<string>( "p2" );
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

        private DelegateCommand _SaveClickCommand;
        /// <summary>
        /// 确定操作
        /// </summary>
        public DelegateCommand SaveClickCommand => _SaveClickCommand ?? ( _SaveClickCommand = new DelegateCommand( () =>
        {
            DialogParameters pars = new DialogParameters();
            pars.Add( "Result1" , "qq1" );
            pars.Add( "Result2" , "qq2" );

            //返回一个对象过去
            pars.Add( "Resultobj" , new People()
            {
                Name = this.Name ,
                Address = this.Address
            } );

            //调用RequestClose就会关闭弹窗
            //DialogResult第1个参数是返回状态,第2个参数是返回的值(如果没有也可以不带参数)
            RequestClose?.Invoke( new DialogResult( ButtonResult.OK , pars ) );


            //如果要传递的参数简单,也可以使用类似web querystring 那样传递参数
            //DialogParameters _Parameters = new DialogParameters( "Result1=qq1&Result2=qq2" );
            //////RequestClose?.Invoke( new DialogResult( ButtonResult.OK , _Parameters ) );
        } ) );


        private DelegateCommand _CancelClickCommand;
        /// <summary>
        /// 取消操作
        /// </summary>
        public DelegateCommand CancelClickCommand => _CancelClickCommand ?? ( _CancelClickCommand = new DelegateCommand( () =>
        {
            //调用RequestClose就会关闭弹窗
            RequestClose?.Invoke( new DialogResult( ButtonResult.Cancel ) );
        } ) );

       

        
    }
}
