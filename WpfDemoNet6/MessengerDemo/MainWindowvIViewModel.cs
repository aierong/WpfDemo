﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using WpfDemoNet6.MessengerDemo.Model;

namespace WpfDemoNet6.MessengerDemo
{
    public partial class MainWindowvIViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "hello";

        public MainWindowvIViewModel ()
        {
            //////注意这样要写,才可以接听
            //////IsActive = true;


            WeakReferenceMessenger.Default.Register<MainWindowvIViewModel , MyMessage , string>( this , "token_Response222" , ( r , message ) =>
            {
                Title = Title + "  收到msg:" + message.Datas;

                //Reply是答复 ,这样可以返回值
                message.Reply( "MainWindowvIViewModel给你返回值" );
            } );


            WeakReferenceMessenger.Default.Register<MainWindowvIViewModel , ValueChangedMessage<string> , string>( this , "token_1" , ( r , message ) =>
            {
                Title = Title + "  收到msg:" + message.Value;
            } );
        }



        //protected override void OnActivated ()
        //{

        //    Messenger.Register<MainWindowvIViewModel , MyMessage , string>( this , "token_Response222" , ( r , message ) =>
        //    {
        //        Title = Title + "  收到msg:" + message.Datas;

        //        //Reply是答复 ,这样可以返回值
        //        message.Reply( "MainWindowvIViewModel给你返回值" );

        //    } );


        //    Messenger.Register<MainWindowvIViewModel,ValueChangedMessage<string> , string>( this , "token_1" , ( r , message ) =>
        //    {
        //        Title = Title + "  收到msg:" + message.Value;
        //    } );

        //}



    }
}
