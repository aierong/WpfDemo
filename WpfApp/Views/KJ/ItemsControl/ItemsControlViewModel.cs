using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.KJ.ItemsControl.Models;

namespace WpfApp.Views.KJ.ItemsControl
{
    public class ItemsControlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> StudentList
        {
            get; set;
        } = new ObservableCollection<string>();

        public ObservableCollection<TodoItem> ItemDatas
        {
            get; set;
        } = new ObservableCollection<TodoItem>() { };

        public ItemsControlViewModel ()
        {
            StudentList = new ObservableCollection<string>() {
                "guoguo" , "juan" , "tom" , "jack" , "wubingbing"
            };

            ItemDatas.Add( new TodoItem() { Title = "Complete this WPF tutorial" , Completion = 45 } );
            ItemDatas.Add( new TodoItem() { Title = "Learn C#" , Completion = 80 } );
            ItemDatas.Add( new TodoItem() { Title = "Wash the car" , Completion = 0 } );
            ItemDatas.Add( new TodoItem() { Title = "car8" , Completion = 8 } );
        }
    }
}
