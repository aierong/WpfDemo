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

namespace WpfApp.Views.TeXiao.PMD.DEMO1
{
    /// <summary>
    /// PMDWindow1.xaml 的互動邏輯
    /// </summary>
    public partial class PMDWindow1 : Window
    {
        public PMDWindow1 ()
        {
            InitializeComponent();

            this.DataContext = new PMDWindow1VM();
        }
    }
}
