using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Prism.Events;
using Prism.Mvvm;

namespace PrismDemo.EventDemo
{
    public class EventMainPageViewModel : BindableBase
    {
        private string _Title = "mainpage";

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                SetProperty( ref _Title , value );
            }
        }

        //IEventAggregator依赖注入
        public EventMainPageViewModel ( IEventAggregator ea )
        {
            //Subscribe的第2个参数是写一个过滤器:可以根据需求把需要的数据接收进来，返回true
            ea.GetEvent<SentDataEvent>().Subscribe( ( Model.MyMessage message ) =>
            {
                Title = Title + "  收到msg:" + message.Datas;
            } , ( Model.MyMessage message ) =>
            {
                //我只要小于2的数据
                return message.Ids < 2;
            } );
        }


    }
}
