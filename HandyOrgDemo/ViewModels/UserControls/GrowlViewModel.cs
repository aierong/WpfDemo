using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Data;
using HandyOrgDemo.Models;

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
            //HandyControl.Controls.Growl.SuccessGlobal( "运行成功(全局)" );  //提示会在窗体外部现实


            //方法名字带Global就是全局的,就是在屏幕最上方，下方等等显示消息 (推荐使用全局)
            //方法名字不带Global,就是在本窗体内部显示提示消息
            //指定token名字  Common.GrowlScriptToken
            //HandyControl.Controls.Growl.Success( "运行成功" , Common.GrowlScriptToken );
            HandyControl.Controls.Growl.SuccessGlobal( new GrowlInfo()
            {
                Token = Common.Common.GrowlScriptToken ,
                Message = "运行成功(全局)" ,
            } );



            HandyControl.Controls.Growl.WarningGlobal( new GrowlInfo()
            {
                Token = Common.Common.GrowlScriptToken ,
                Message = "运行成功(全局)" ,
            } );

        }



        public GrowlViewModel ()
        {

        }
    }
}
