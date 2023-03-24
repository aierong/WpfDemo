using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;



namespace WpfDemoNet6.MessengerDemo.Model
{
    /// <summary>
    /// 必须继承RequestMessage  RequestMessage<string>代表返回数据的类型是string
    /// </summary>
    public class MyMessage : RequestMessage<string>
    {
        public string Datas;

        public int Ids;
    }
}
