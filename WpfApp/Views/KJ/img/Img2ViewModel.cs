using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BaseCommand;

namespace WpfApp.Views.KJ.img
{
    public  class Img2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string netimgname;

        /// <summary>
        /// 名字
        /// </summary>
        public string NetImgName
        {
            get
            {
                return netimgname;
            }
            set
            {
                netimgname = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "NetImgName" ) );
            }
        }


        public Img2ViewModel ()
        {
             
            NetImgName = "\\\\10.12.0.151\\misfile\\test\\images\\BQC.jpg";


            //UpdateImgCommand = new MyCommand( () =>
            //{
            //    Debug.WriteLine( "UpdateImgCommand:" );

            //    ImgName = "/Imgs/VER.png";
            //} );
        }

    }
}
