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

            //第一个参数是发送的消息值,第2个参数是token,可以给接收方区分用的 推荐每次都带上token，方便接收方区分
            //WeakReferenceMessenger.Default.Send<string , string>( "UserControlLeftViewModel发来的qq1" , "token_1" );

            //特别注意:直接传递值,只可以是引用类型,值类型不可以编译成功的(例如:下面2句不行)
            //WeakReferenceMessenger.Default.Send<int , string>( 11 , "token_1" );
            //WeakReferenceMessenger.Default.Send<bool , string>( true  , "token_1" );

            //上面这样也是可以的，但是官方推荐用ValueChangedMessage封装数据传递
            WeakReferenceMessenger.Default.Send<ValueChangedMessage<string> , string>( new ValueChangedMessage<string>( "UserControlLeftViewModel发来的qq1" ) , "token_1" );
            //下面2句,由于用ValueChangedMessage,所以bool,int类型数据都可以
            //WeakReferenceMessenger.Default.Send<ValueChangedMessage<bool> , string>( new ValueChangedMessage<bool>( true ) , "token_1" );
            //WeakReferenceMessenger.Default.Send<ValueChangedMessage<int> , string>( new ValueChangedMessage<int>( 123456 ) , "token_1" );


            //Send发送 一个复杂数据 
            var _data1 = new MyUserMessage() { Age = 18 , UserName = "qq" };
            //WeakReferenceMessenger.Default.Send<MyUserMessage , string>( _data1 , "token_class" );
            WeakReferenceMessenger.Default.Send<ValueChangedMessage<MyUserMessage> , string>( new ValueChangedMessage<MyUserMessage>( _data1 ) , "token_class" );

            //result接收返回的值
            //MyMessage这个类必须继承RequestMessage
            var _data2 = new MyMessage() { Datas = "qqq" , Ids = 100 };
            var result = WeakReferenceMessenger.Default.Send<MyMessage , string>( _data2 , "token_Response" );
            if ( result != null )
            {
                //获取到 返回的值
                var val = result.Response;
                
                Name = val;
            }
        }
    }


}
