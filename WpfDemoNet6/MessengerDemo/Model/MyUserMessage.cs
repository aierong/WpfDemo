using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace WpfDemoNet6.MessengerDemo.Model
{
    public class MyUserMessage
    {
        public string UserName
        {
            get; set;
        }

      

        public int Age
        {
            get; set;
        }
    }
}
