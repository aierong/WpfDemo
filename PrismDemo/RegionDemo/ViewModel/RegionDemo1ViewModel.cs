using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismDemo.RegionDemo.UC;

namespace PrismDemo.RegionDemo.ViewModel
{
    public class RegionDemo1ViewModel : BindableBase
    {
         

        IRegionManager _regionManager;

        public RegionDemo1ViewModel ( IRegionManager regionManager )
        {
            this._regionManager = regionManager;

            //把内容的用户控件加载到ContentRegion区域
            this._regionManager.RegisterViewWithRegion( "ContentRegion" , typeof( UserControlContent ) );
            this._regionManager.RegisterViewWithRegion( "HeaderRegion" , typeof( UserControlHeader ) );
        }



    }
}