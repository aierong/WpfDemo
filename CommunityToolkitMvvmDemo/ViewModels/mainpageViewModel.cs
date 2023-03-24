using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkitMvvmDemo.Models;
using CommunityToolkitMvvmDemo.ViewModels.UC;

namespace CommunityToolkitMvvmDemo.ViewModels
{
    public partial class mainpageViewModel : ObservableRecipient
    {
        /// <summary>
        /// sql文本
        /// </summary>
        [ObservableProperty]
        private string sqlTxt = "";



        public mainpageViewModel ()
        {
            //注意这样要写,才可以接听
            IsActive = true;
        }


        protected override void OnActivated ()
        {
            Messenger.Register<mainpageViewModel , Student , string>( this , Common.Constant.tokenname_studentvaluechage , ( r , message ) =>
            {
                string mb = string.Format( "insert into tb(Name,Class,Phone) values('{0}','{1}','{2}')" ,
                                                        message.Name ,
                                                        message.Class ,
                                                        message.Phone );

                SqlTxt = mb;
            } );
        }


    }
}
