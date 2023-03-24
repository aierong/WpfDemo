using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkitMvvmDemo.Models;



namespace CommunityToolkitMvvmDemo.ViewModels.UC
{
    public partial class StudentFormViewModel : ObservableRecipient
    {
        public StudentFormViewModel ()
        {
            //注意这样要写,才可以接听
            IsActive = true;



            Name = string.Empty;
            Phone = string.Empty;
            Class = string.Empty;
        }



        protected override void OnActivated ()
        {
            //接收消息
            Messenger.Register<StudentFormViewModel , string , string>( this , Common.Constant.tokenname_userselect , ( r , message ) =>
            {
                this.isShow = message == "1";

                //通知命令
                AddClickCommand.NotifyCanExecuteChanged();
            } );
        }

        [RelayCommand( CanExecute = nameof( CanAddNew ) )]
        private void AddClick ()
        {
            //这里 没有验证

            //发送消息
            var data = new Student()
            {
                Class = this.Class ,
                Name = this.Name ,
                Phone = this.Phone
            };
            WeakReferenceMessenger.Default.Send<Student , string>( data , Common.Constant.tokenname_student );

        }

        private bool isShow = false;

        private bool CanAddNew ()
        {
            return this.isShow;
        }

        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private string phone = "";

        [ObservableProperty]
        private string _class = "";

        partial void OnNameChanged ( string value )
        {
            this.sendmsg();
        }

        partial void OnClassChanged ( string value )
        {
            this.sendmsg();
        }

        partial void OnPhoneChanged ( string value )
        {
            this.sendmsg();
        }



        /// <summary>
        /// 发送消息
        /// </summary>
        void sendmsg ()
        {
            //发送消息，通知
            var data = new Student()
            {
                Class = this.Class ,
                Name = this.Name ,
                Phone = this.Phone
            };
            WeakReferenceMessenger.Default.Send<Student , string>( data , Common.Constant.tokenname_studentvaluechage );

        }
    }
}
