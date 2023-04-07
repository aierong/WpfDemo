using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfApp.Views.BaseCommand;
using WpfApp.Views.KJ.Base;

namespace WpfApp.Views.KJ.img
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ImageViewModel ()
        {
            ImgName = "/Imgs/zhonghe1.png";

            UpdateImgCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "UpdateImgCommand:" );

                ImgName = "/Imgs/VER.png";
            } );
        }

        private string imgname;

        /// <summary>
        /// 名字
        /// </summary>
        public string ImgName
        {
            get
            {
                return imgname;
            }
            set
            {
                imgname = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "ImgName" ) );
            }
        }

        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand UpdateImgCommand
        {
            get; set;
        }
    }
}
