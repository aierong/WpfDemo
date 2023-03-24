using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkitMvvmDemo.Models;



namespace CommunityToolkitMvvmDemo.ViewModels.UC
{
    public partial class StudentListViewModel : ObservableObject
    {
        public ObservableCollection<Student> Students
        {
            get;
        } = new ObservableCollection<Student>() { };

        public StudentListViewModel ()
        {

        }



        [RelayCommand()]
        void CBClick ( bool isselect )
        {
            //发送消息，通知
            WeakReferenceMessenger.Default.Send<ValueChangedMessage<bool> , string>( new ValueChangedMessage<bool>( isselect ) , 
                                                                            Common.Constant.tokenname_userselect );


        }



    }
}
