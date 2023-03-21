using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;


namespace WpfDemoNet6.MessengerDemo
{
    public partial class MainWindowvIViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string title = "hello";

        public MainWindowvIViewModel ()
        {
            //注意这样要写,才可以接听
            IsActive = true;
        }

        protected override void OnActivated ()
        {
            


            Messenger.Register<MainWindowvIViewModel , string , string>( this , "token_1" , ( r , message ) =>
            {
               

                Title = Title + "  收到msg:" + message;
            } );

        }
    }
}
