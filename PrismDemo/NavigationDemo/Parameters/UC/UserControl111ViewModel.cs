using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;

/*
INavigationAware接口3个方法:

OnNavigatedFrom：导航之前触发(导航离开当前页时触发),一般用于保存该页面的数据
OnNavigatedTo：导航后目的页面触发，一般用于初始化或者接受上页面的传递参数
IsNavigationTarget：True则重用该View实例，Flase则每一次导航到该页面都会实例化一次
*/

namespace PrismDemo.NavigationDemo.Parameters.UC
{
    public class UserControl111ViewModel : BindableBase, INavigationAware
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            //IsNavigationTarget配置是否重用现有视图
            // 导航离开后,再回来这个页面,视图是否重用现有视图

            //默认用true,就是重用之前的视图,之前的操作等数据都还在
            //false,就是重新初始化一个新的视图
            return true;
        }



        /// <summary>
        /// 导航离开当前页时触发
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {
            //导航离开当前页时触发

            return;
        }



        /// <summary>
        /// 导航完成前,接收用户传递参数或者一些初始化工作
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnNavigatedTo ( NavigationContext navigationContext )
        {
            if ( navigationContext.Parameters["ptitle"] != null )
            {
                //框架提供方便获取值的方法：GetValue
                Title = navigationContext.Parameters.GetValue<string>( "ptitle" );

                //这样也可以
                //navigationContext.Parameters["ptitle"].ToString();
            }
            else
            {
                //没有收到参数哦
            }



            if ( navigationContext.Parameters["num"] != null )
            {
                Num = navigationContext.Parameters.GetValue<int>( "num" );
                //这样也可以
                //Num = Convert.ToInt32( navigationContext.Parameters["num"]  );
            }



            if ( navigationContext.Parameters["listdata"] != null )
            {
                var list = navigationContext.Parameters.GetValue<List<string>>( "listdata" );
                //这样也可以
                //var list = ( List<string> ) navigationContext.Parameters["listdata"];
            }
        }








        private string _Title = "";

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


        private int _num = 0;

        public int Num
        {
            get
            {
                return _num;
            }
            set
            {
                SetProperty( ref _num , value );
            }
        }



    }
}
