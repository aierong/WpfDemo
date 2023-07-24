using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WpfApp.Views.KJ.RadioButtons
{
    public class UCRadioButtonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public UCRadioButtonViewModel ()
        {
            UserSelectDisplayType = DisplayType.None;
        }


        private DisplayType _DisplayType;


        public DisplayType UserSelectDisplayType
        {
            get
            {
                return _DisplayType;
            }
            set
            {
                _DisplayType = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "UserSelectDisplayType" ) );
            }
        }
    }



    public enum DisplayType
    {
        Good,
        Bad,
        None
    }

}
