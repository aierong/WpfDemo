using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.KJ.Base;

namespace WpfApp.Views.KJ.Tab
{
    public partial class TabViewModel :    INotifyPropertyChanged
    {
     
        

        public event PropertyChangedEventHandler PropertyChanged;

        public TabViewModel ()
        {
            UserSelectIndex = 1;

            //UpdateImgCommand = new MyCommand( () =>
            //{
            //    Debug.WriteLine( "UpdateImgCommand:" );

            //    ImgName = "/Imgs/VER.png";
            //} );
        }


        private int userSelectIndex = 1;

        /// <summary>
        /// 名字
        /// </summary>
        public int UserSelectIndex
        {
            get
            {
                return userSelectIndex;
            }
            set
            {
                userSelectIndex = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "UserSelectIndex" ) );
            }
        }

        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand UpdateNextCommand
        {
            get; set;
        }

    }
}
