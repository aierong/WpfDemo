using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;
using Prism.Regions;

//IConfirmNavigationRequest是继承INavigationAware的

namespace PrismDemo.NavigationDemo.ConfirmNavigation.UC
{
    public class UserControlAAAViewModel : BindableBase, IConfirmNavigationRequest
    {
        public void ConfirmNavigationRequest ( NavigationContext navigationContext , Action<bool> continuationCallback )
        {
            //导航准备离开页面时,触发这个事件
            //可以做一些判断,阻止导航

            bool result = true;

            if ( MessageBox.Show( "您还有数据未保存,您确定转向吗?" , "温馨提示" , MessageBoxButton.YesNo ) != MessageBoxResult.Yes )
            {
                //这样导航就会停止
                result = false;
            }

            continuationCallback( result );
        }



        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            //默认用true
            return true;
        }



        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {

        }



        public void OnNavigatedTo ( NavigationContext navigationContext )
        {
            //可以获取一些参数等等

        }
    }
}
