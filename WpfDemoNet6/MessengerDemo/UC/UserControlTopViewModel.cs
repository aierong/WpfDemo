using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

//IRecipient<string>

namespace WpfDemoNet6.MessengerDemo.UC
{
    public partial class UserControlTopViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string name = "hello";

        public UserControlTopViewModel ()
        {
            //注意这样要写,才可以接听
            IsActive = true;
        }


        

        protected override void OnActivated ()
        {

            
            Messenger.Register<UserControlTopViewModel , string>( this , ( r , message ) =>
            {
                Name = Name + "  收到msg:" + message;

                //message.r
            } );



            //Messenger.Register<UserControlTopViewModel , string , string>( this , "token_1" , ( r , message ) =>
            //{
            //    Name = Name + "  收到msg:" + message;
            //} );


            Messenger.Register<UserControlTopViewModel , MyMessage>( this , ( r , message ) =>
            {
                Name = Name + "  收到msg:" + message.Datas ;


                //Reply是答复 ,这样可以返回值
                message.Reply("给你返回值");
                                 
            } );
        }

         

        //public void Receive ( string message )
        //{
        //    Name = Name + "  收到msg:" + message;
        //}



        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮,修改标题
            Name = "hello(Top改)";
        }
    }
}
