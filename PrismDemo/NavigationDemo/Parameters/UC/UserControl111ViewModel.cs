using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismDemo.NavigationDemo.Parameters.UC
{
    public class UserControl111ViewModel : BindableBase, INavigationAware
    {



        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            return true;
        }



        /// <summary>
        /// 导航离开当前页时触发
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {

        }



        /// <summary>
        /// 导航完成前,接收用户传递参数或者是否允许导航等控制
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
