using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;



namespace ValueConvertersNetDemo.ViewModels.UC
{
    public class GroupUserControl1ViewModel : BindableBase
    {

        private int _Num = 0;

        public int Num
        {
            get
            {
                return _Num;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _Num , value );
            }
        }


        private int _NumTwo = 100;

        public int NumTwo
        {
            get
            {
                return _NumTwo;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _NumTwo , value );
            }
        }

        private DelegateCommand _QieHuanClickCommand;
        public DelegateCommand QieHuanClickCommand => _QieHuanClickCommand ?? ( _QieHuanClickCommand = new DelegateCommand( () =>
        {
            Random _random = new Random();
            var randomValue = _random.Next( 1 , 10 );

            Num = randomValue;

            NumTwo = NumTwo == 100 ? 200 : 100;
        } ) );

    }
}
