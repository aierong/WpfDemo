using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfApp.Views.BaseCommand;

//参考: https://wpf-tutorial.com/zh/493/%E5%9F%BA%E6%9C%AC%E6%8E%A7%E5%88%B6%E9%A0%85/image%E6%8E%A7%E4%BB%B6/

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

                //改变图片
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
