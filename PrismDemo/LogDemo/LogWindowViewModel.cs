using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Microsoft.Extensions.Logging;

//写日志

namespace PrismDemo.LogDemo
{
    public class LogWindowViewModel : BindableBase
    {
        private DelegateCommand _AButtonClickCommand;
        public DelegateCommand AButtonClickCommand => _AButtonClickCommand ?? ( _AButtonClickCommand = new DelegateCommand( () =>
        {
            //int i = 0;
            //int j = 100 / i;

            //导航 
            this._regionManager.RequestNavigate( "ContentRegion" , "AAAUC" );

            //写日志
            this.logger.LogInformation( "msg:主窗体写入" );
                        
        } ) );


        private DelegateCommand _BButtonClickCommand;
        public DelegateCommand BButtonClickCommand => _BButtonClickCommand ?? ( _BButtonClickCommand = new DelegateCommand( () =>
        {
            //导航 
            this._regionManager.RequestNavigate( "ContentRegion" , "BBBUC" );
        } ) );


        IRegionManager _regionManager;
        ILogger logger;


        public LogWindowViewModel ( IRegionManager regionManager , ILogger logger )
        {

            this._regionManager = regionManager;
            this.logger = logger;
                        
        }
    }
}
