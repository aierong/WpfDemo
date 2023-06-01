﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using WpfApp.Views.BaseCommand;

//参考:https://wpf-tutorial.com/zh/493/%E5%9F%BA%E6%9C%AC%E6%8E%A7%E5%88%B6%E9%A0%85/image%E6%8E%A7%E4%BB%B6/

//本demo中使用图片，在本目录images中有



namespace WpfApp.Views.KJ.img
{
    public class Img2ViewModel : INotifyPropertyChanged
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


        private System.Windows.Media.ImageSource imgdata = null;

        public System.Windows.Media.ImageSource ImgData
        {
            get
            {
                return imgdata;
            }
            set
            {
                imgdata = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "ImgData" ) );
            }
        }



        public Img2ViewModel ()
        {
            //本demo中使用图片，在本目录images中有
            NetImgName = "\\\\10.12.0.151\\misfile\\test\\images\\BQC.jpg";


            UpdateImgCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "UpdateImgCommand:" );

                //改变图片
                NetImgName = "\\\\10.12.0.151\\misfile\\test\\images\\zhonghe1.png";
            } );

            SelectImgCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "SelectImgCommand:" );

                //弹窗选择图片
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if ( openFileDialog.ShowDialog() == true )
                {
                    Uri fileUri = new Uri( openFileDialog.FileName );
                    ImgData = new BitmapImage( fileUri );
                }
            } );
        }


        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand UpdateImgCommand
        {
            get; set;
        }


        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand SelectImgCommand
        {
            get; set;
        }
    }
}