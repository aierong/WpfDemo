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
    public class UserControlLeftViewModel : BindableBase
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


        private DelegateCommand _ButtonClickCommand;
        public DelegateCommand ButtonClickCommand => _ButtonClickCommand ?? ( _ButtonClickCommand = new DelegateCommand( () =>
        {
            //点击按钮,修改标题
            Name = "hello(Left改)";

            //发送消息
            this._eventAggregator.GetEvent<SentEvent>().Publish( "UserControlLeftViewModel发来的qq1" );

            this._eventAggregator.GetEvent<SentDataEvent<Model.MyMessage>>().Publish( new Model.MyMessage() { Ids = 123 , Datas = "name1" } );

            this._eventAggregator.GetEvent<SentDataEvent<Model.MyMessage>>().Publish( new Model.MyMessage() { Ids = 1 , Datas = "11" } );
            this._eventAggregator.GetEvent<SentDataEvent<Model.MyMessage>>().Publish( new Model.MyMessage() { Ids = 2 , Datas = "22" } );


        } ) );

        IEventAggregator _eventAggregator;

        //IEventAggregator依赖注入
        public UserControlLeftViewModel ( IEventAggregator ea )
        {
            this._eventAggregator = ea;
        }


    }
}
