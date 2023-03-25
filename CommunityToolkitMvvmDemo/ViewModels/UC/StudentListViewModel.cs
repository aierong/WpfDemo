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
    public partial class StudentListViewModel : ObservableRecipient
    {
        public ObservableCollection<Student> Students
        {
            get;
        } = new ObservableCollection<Student>() { };


        public int StudentCount
        {
            get
            {
                return Students.Count;
            }
        }

        public StudentListViewModel ()
        {
            //注意这样要写,才可以接听
            IsActive = true;

            Students.CollectionChanged += Students_CollectionChanged;
        }



        private void Students_CollectionChanged ( object? sender , System.Collections.Specialized.NotifyCollectionChangedEventArgs e )
        {
            //throw new NotImplementedException();

            OnPropertyChanged( nameof( StudentCount ) );
        }

        protected override void OnActivated ()
        {
            Messenger.Register<StudentListViewModel , ValueChangedMessage<Student> , string>( this , Common.Constant.tokenname_student , ( r , val ) =>
            {
                Students.Add( val.Value );
            } );
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
