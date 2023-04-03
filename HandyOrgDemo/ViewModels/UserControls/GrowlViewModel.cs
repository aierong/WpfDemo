using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class GrowlViewModel : ObservableObject
    {
        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮 

            //Debug.WriteLine( "ButtonClick" );

            //HandyControl.Controls.Growl.Success( "运行成功" );   //提示会在窗体内部现实
            HandyControl.Controls.Growl.SuccessGlobal( "运行成功1" );  //提示会在窗体外部现实

            //HandyControl.Controls.Growl.Success( "运行成功1" , GrowlScriptToken );
        }

        public static readonly string GrowlScriptToken = "msgone";

        public GrowlViewModel ()
        {

        }
    }
}
