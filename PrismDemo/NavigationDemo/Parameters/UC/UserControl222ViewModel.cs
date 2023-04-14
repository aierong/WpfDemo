using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;



namespace PrismDemo.NavigationDemo.Parameters.UC
{
    public class UserControl222ViewModel : BindableBase, INavigationAware
    {
        public bool IsNavigationTarget ( NavigationContext navigationContext )
        {
            return true;
        }

        public void OnNavigatedFrom ( NavigationContext navigationContext )
        {
            
        }

        public void OnNavigatedTo ( NavigationContext navigationContext )
        {
            if ( navigationContext.Parameters["p1"] != null )
            {
                //框架提供方便获取值的方法：GetValue
                Title = navigationContext.Parameters.GetValue<string>( "p1" );
            }
            else
            {
                //没有收到参数哦
            }


            if ( navigationContext.Parameters["p2"] != null )
            {
                Num = navigationContext.Parameters.GetValue<int>( "p2" );
                
                
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
