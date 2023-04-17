using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace PrismDemo.IOCDemo.Demo1
{
    public class IOCWindowOneViewModel : BindableBase
    {
        IOCDemo.Demo1.Service.Service.IBill _bill;

        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="bill"></param>
        public IOCWindowOneViewModel ( IOCDemo.Demo1.Service.Service.IBill bill )
        {
            this._bill = bill;
        }



        private DelegateCommand _ButtonClickCommand;
        public DelegateCommand ButtonClickCommand => _ButtonClickCommand ?? ( _ButtonClickCommand = new DelegateCommand( () =>
        {
            Title = this._bill.GetData("qq");
        } ) );



        private string _Title = "initvm";

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _Title , value );
            }
        }



    }
}
