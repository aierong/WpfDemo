using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using PrismDemo.DialogDemo.Models;

namespace PrismDemo.DialogDemo
{
    public class DialogWindowViewModel : BindableBase
    {
        private string _MyMsg = string.Empty;

        public string MyMsg
        {
            get
            {
                return _MyMsg;
            }
            set
            {
                SetProperty( ref _MyMsg , value );
            }
        }

        public DelegateCommand ButtonClickCommand
        {
            get; private set;
        }

        IDialogService _dialogService;

        /// <summary>
        /// 构造函数依赖注入 IDialogService dialogService
        /// </summary>
        /// <param name="dialogService"></param>
        public DialogWindowViewModel ( IDialogService dialogService )
        {
            this._dialogService = dialogService;



            ButtonClickCommand = new DelegateCommand( () =>
            {
                //打开对话框之前,可以定义一些参数传递过去
                DialogParameters pars = new DialogParameters();
                pars.Add( "p1" , "qq1" );
                pars.Add( "p2" , "qq2" );
                //传递一个对象过去
                pars.Add( "pobj" , new People()
                {
                    Name = "xiao ming" ,
                    Address = "东莞"
                } );

                //ShowDialog方法
                //第1个参数是:App.xaml中注册对话框起的名字 mydlgone
                //第2个参数是:传递参数给对话框
                //第3个参数是:传递参数给对话框
                this._dialogService.ShowDialog( "mydlgone" , pars , ( IDialogResult ir ) =>
                {
                    //先判断,返回的状态
                    if ( ir.Result == ButtonResult.OK )
                    {
                        //这里再接收一下返回的参数
                        if ( ir.Parameters.ContainsKey( "Result1" ) )
                        {
                            var val = ir.Parameters.GetValue<string>( "Result1" );
                        }
                        if ( ir.Parameters.ContainsKey( "Result1obj" ) )
                        {
                            var _People = ir.Parameters.GetValue<People>( "Result1obj" );
                            this.MyMsg = string.Format( "弹窗给我返回:Name:{0} Address:{1}" , _People.Name , _People.Address );
                        }
                    }
                    else
                    {
                        MessageBox.Show( "点击了取消按钮" );
                    }

                } );



                //如果要传递的参数简单,也可以使用类似web querystring 那样传递参数
                //DialogParameters _Parameters = new DialogParameters( "p1=qq1&p2=qq2" );
                //this._dialogService.ShowDialog( "mydlgone" , _Parameters , ( IDialogResult ir ) =>
                //{
                //    //相关逻辑代码

                //} );

            } );
        }

    }
}
