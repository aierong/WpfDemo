﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp.Views.TeXiao.EmojiDemo
{
    /// <summary>
    /// EmojiWindow1.xaml 的互動邏輯
    /// </summary>
    public partial class EmojiWindow1 : Window
    {
        public EmojiWindow1 ()
        {
            InitializeComponent();

            this.DataContext = new datawindowviewmodel();
        }
    }
}
