using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

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

            WeakReferenceMessenger.Default.Send( "qq1" );

            //第一个参数是发送的消息值,第2个参数是token,可以给接收方区分用的
            //WeakReferenceMessenger.Default.Send( "UserControlLeftViewModel发来的qq1" , "token_1" );



            //reMyMessage可以接收返回的值
            var reMyMessage = WeakReferenceMessenger.Default.Send<MyMessage>( new MyMessage() { Datas = "qqq" } );
            if( reMyMessage != null )
            {
                //获取到 返回的值
                var val = reMyMessage.Response;

                Name = val;
            }
        }
    }


    public class MyMessage : RequestMessage<string>
    {
        public string Datas;

    }
}
