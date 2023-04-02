using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyOrgDemo.Views.UserControls;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class PopupWindowViewModel : ObservableObject
    {
        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮 

            //Debug.WriteLine( "ButtonClick" );

            PopupWindowDemo1 popwin = new PopupWindowDemo1();
            HandyControl.Controls.PopupWindow pwin = new HandyControl.Controls.PopupWindow();
            pwin.PopupElement = popwin;

            //调用另一个用户控件,弹窗
            pwin.Show();
            //模态化显示窗口
            //pwin.ShowDialog ();
        }

        public PopupWindowViewModel ()
        {

        }
    }
}
