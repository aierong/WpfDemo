using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class MessageBoxViewModel : ObservableObject
    {
        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮 

            //Debug.WriteLine( "ButtonClick" );

            HandyControl.Controls.MessageBox.Success( "运行成功" , "OK了" );
            HandyControl.Controls.MessageBox.Error( "错误了" , "error了" );
        }

        [RelayCommand()]
        void ButtonAskClick ()
        {
            //点击按钮 

            //Debug.WriteLine( "ButtonClick" );

            var dlg = HandyControl.Controls.MessageBox.Show( "运行吗?" , "确定" , MessageBoxButton.YesNo );

            if ( dlg == MessageBoxResult.Yes )
            {
                HandyControl.Controls.MessageBox.Success( "你点击了yes" );
            }
        }

        public MessageBoxViewModel ()
        {

        }
    }
}
