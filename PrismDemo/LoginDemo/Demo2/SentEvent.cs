using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace PrismDemo.LoginDemo.Demo2
{
    /// <summary>
    /// 只可以传递字符串
    /// </summary>
    public class SentEvent : PubSubEvent<string>
    {
    }
}
