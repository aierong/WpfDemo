﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

//1.实现接口 INotifyDataErrorInfo

namespace WpfApp.Views.ValidationData.demo1.viewmodel
{
    public class datawindowviewmodel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public datawindowviewmodel ()
        {

            Name = "Name_init";

            Title = "init";

            Age = 18;

            //ShowCommand = new MyCommand( Show    );

        }

        private string name;

        /// <summary>
        /// 名字
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
            }
        }

        private string title;


        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get => title;

            set
            {
                title = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Title" ) );
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;

                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Age" ) );
            }
        }



        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }
                      

        public void Show ()
        {
            Name = "改了";
            Title = "le title";

            MessageBox.Show( "show Command" );
        }

















        
    }
}
