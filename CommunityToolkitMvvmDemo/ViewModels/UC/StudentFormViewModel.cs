using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommunityToolkitMvvmDemo.ViewModels.UC
{
    public partial class StudentFormViewModel : ObservableRecipient
    {
        public StudentFormViewModel ()
        {
            //注意这样要写,才可以接听
            IsActive = true;
        }



        protected override void OnActivated ()
        {
            Messenger.Register<StudentFormViewModel , string , string>( this , Common.Constant.tokenname_userselect , ( r , message ) =>
            {
                if ( string.IsNullOrEmpty( message ) )
                {
                }
            } );
        }



    }
}
