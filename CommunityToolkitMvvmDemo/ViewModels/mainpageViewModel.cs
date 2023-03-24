using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
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
            Messenger.Register<mainpageViewModel , ValueChangedMessage<Student> , string>( this , Common.Constant.tokenname_studentvaluechage , ( r , val ) =>
            {
                string mb = string.Format( "insert into tb(Name,Class,Phone) values('{0}','{1}','{2}')" ,
                                                        val.Value.Name ,
                                                        val.Value.Class ,
                                                        val.Value.Phone );

                SqlTxt = mb;
            } );
        }


    }
}
