using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using PrismDemo.IOCDemo.Demo1.Service;

namespace PrismDemo.IOCDemo.Demo1
{
    public class IOCWindowOneViewModel : BindableBase
    {
        IOCDemo.Demo1.Service.Service.IBill _bill;
        IContainerExtension container;


        IPerson personman;
        IPerson personwoman;

        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="bill"></param>
        public IOCWindowOneViewModel ( IContainerExtension _container, IOCDemo.Demo1.Service.Service.IBill bill )
        {
            this.container = _container;

            //这里的2个名字，就是app.xaml.cs中定义的名字
            personman = this.container.Resolve<IPerson>( "man" );//man
            personwoman = this.container.Resolve<IPerson>( "woman" );//woman


            this._bill = bill;
            //下面这样获取方式也是可以的
            //this._bill = this.container.Resolve<IOCDemo.Demo1.Service.Service.IBill>();

        }



        private DelegateCommand _ButtonClickCommand;
        public DelegateCommand ButtonClickCommand => _ButtonClickCommand ?? ( _ButtonClickCommand = new DelegateCommand( () =>
        {
            Title = this._bill.GetData("qq");

            var s1 = this.personman.Sex;
            var s2 = this.personwoman.Sex;
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
