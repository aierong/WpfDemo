using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismDemo.LoginDemo.Demo2.UC
{
    public class UCChild2VM : BindableBase, INavigationAware
    {
        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            //IsNavigationTarget配置是否重用现有视图
            // 导航离开后,再回来这个页面,视图是否重用现有视图

            //默认用true,就是重用之前的视图,之前的操作等数据都还在
            //false,就是重新初始化一个新的视图
            return false;
        }

        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo ( NavigationContext navigationContext )
        {
            //throw new NotImplementedException();
        }

        public UCChild2VM()
        {
            TextTitle = "B" + DateTime.Now.ToLongTimeString();
        }


        private string _TextTitle = "init—vm";

        public string TextTitle
        {
            get
            {
                return _TextTitle;
            }
            set
            {
                SetProperty( ref _TextTitle , value );
            }
        }
    }
}
