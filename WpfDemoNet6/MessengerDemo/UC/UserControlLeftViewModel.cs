using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using WpfDemoNet6.MessengerDemo.Model;

//ObservableObject 
namespace WpfDemoNet6.MessengerDemo.UC
{
    public partial class UserControlLeftViewModel : ObservableObject
    {
        [ObservableProperty]
        private string name = "hello";

        public UserControlLeftViewModel ()
        {

        }



        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮,修改标题
            Name = "hello(Left改)";

            //Send发送消息
            WeakReferenceMessenger.Default.Send<string>( "qq1" );

            //第一个参数是发送的消息值,第2个参数是token,可以给接收方区分用的
            WeakReferenceMessenger.Default.Send<string , string>( "UserControlLeftViewModel发来的qq1" , "token_1" );

            //Send发送 一个复杂数据 
            WeakReferenceMessenger.Default.Send<MyUserMessage , string>( new MyUserMessage() { Age = 18 , UserName = "qq" } , "token_class" );

            //reMyMessage可以接收返回的值
            var result = WeakReferenceMessenger.Default.Send<MyMessage , string>( new MyMessage() { Datas = "qqq" , Ids = 100 } , "token_Response" );
            if ( result != null )
            {
                //获取到 返回的值
                var val = result.Response;

                Name = val;
            }
        }
    }


    //public class MyMessage : RequestMessage<string>
    //{
    //    public string Datas;

    //}
}
