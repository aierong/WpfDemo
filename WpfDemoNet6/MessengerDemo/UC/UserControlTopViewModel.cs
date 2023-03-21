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
using WpfDemoNet6.MessengerDemo.Model;

/*
接收2种方式:

方式1.继承ObservableRecipient  

方式2.实现接口IRecipient

推荐使用方式1,方式2不太灵活,它只可以一个模型接收一个数据,并且无法实现token区分
*/

//IRecipient<string> ,ObservableObject
//ObservableRecipient
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
            //Register<>第一个类型一般是自己的类型,第2个是接收数据的类型
            //Register方法第1个参数一般是this,第2个参数是一个方法,可以获取接收到的值
            Messenger.Register<UserControlTopViewModel , string>( this , ( r , message ) =>
            {
                Name = Name + "  收到msg:" + message;
            } );

            //Register<>第一个类型一般是自己的类型,第2个是接收数据的类型,第3个是token数据的类型
            //Register方法第1个参数一般是this,第2个参数是token,第3个参数是一个方法,可以获取接收到的值
            Messenger.Register<UserControlTopViewModel , string , string>( this , "token_1" , ( r , message ) =>
            {

                Name = Name + "  收到msg:" + message;
            } );
                              


            Messenger.Register<UserControlTopViewModel , MyUserMessage , string>( this , "token_class" , ( r , user ) =>
            {
                Name = Name + "  收到msg:" + user.UserName + user.Age;
            } );


            Messenger.Register<UserControlTopViewModel , MyMessage , string>( this , "token_Response" , ( r , message ) =>
            {
                Name = Name + "  收到msg:" + message.Datas;


                //Reply是答复 ,这样可以返回值
                message.Reply( "给你返回值" );

            } );
        }



        ///// <summary>
        ///// 接收数据
        ///// </summary>
        ///// <param name="message"></param>
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
