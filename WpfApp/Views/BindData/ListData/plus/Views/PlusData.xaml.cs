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
using WpfApp.Views.BindData.ListData.plus.ViewModels;

namespace WpfApp.Views.BindData.ListData.plus.Views
{
    /// <summary>
    /// PlusData.xaml 的交互逻辑
    /// </summary>
    public partial class PlusData : Window
    {
        public PlusData ()
        {
            InitializeComponent();

            this.DataContext = new PlusDataViewModel();
        }
    }
}
