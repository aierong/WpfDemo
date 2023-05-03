using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Microsoft.Extensions.Logging;
using Prism.Commands;

namespace PrismDemo.LogDemo.UC
{
    public class AAAUserControlViewModel : BindableBase
    {
        ILogger logger;

        public AAAUserControlViewModel ( ILogger logger )
        {
            this.logger = logger;
        }



        private DelegateCommand _MyButtonClickCommand;
        public DelegateCommand MyButtonClickCommand => _MyButtonClickCommand ?? ( _MyButtonClickCommand = new DelegateCommand( () =>
        {
            //写日志
            this.logger.LogInformation( "msg:A用户控件写入" );
        } ) );

    }
}
