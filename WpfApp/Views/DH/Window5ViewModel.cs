﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.DH
{
    public class Window5ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public Window5ViewModel ()
        {
            IsAnimation = true;
        }

        private bool isAnimation = true;


        public bool IsAnimation
        {
            get => isAnimation;

            set
            {
                isAnimation = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "IsAnimation" ) );
            }
        }
    }
}
