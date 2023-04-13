using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace PrismDemo.EventDemo.UC
{
    public class UserControlTopViewModel : BindableBase
    {
        private string _Name = string.Empty;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                SetProperty( ref _Name , value );
            }
        }

        public DelegateCommand ButtonClickCommand
        {
            get; private set;
        }


        //IEventAggregator依赖注入
        public UserControlTopViewModel ( IEventAggregator ea )
        {
            ea.GetEvent<SentEvent>().Subscribe( ( string message ) =>
            {
                Name = Name + "  收到msg:" + message;
            } );

            ea.GetEvent<SentDataEvent>().Subscribe( ( Model.MyMessage message ) =>
            {
                Name = Name + "  收到msg:" + message.Datas;
            } );


            //Subscribe的第2个参数是写一个过滤器:可以根据需求把需要的数据接收进来，返回true
            ea.GetEvent<SentDataEvent>().Subscribe( ( Model.MyMessage message ) =>
            {
                Name = Name + "  收到msg:" + message.Datas;
            } , ( Model.MyMessage message ) =>
            {
                //我只要小于2的数据
                return message.Ids < 2;
            } );


            ButtonClickCommand = new DelegateCommand( () =>
            {
                //点击按钮,修改标题
                Name = "hello(Top改)";

            } );
        }


    }
}
