using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BindData.ListData.plus.Models;

namespace WpfApp.Views.BindData.ListData.plus.ViewModels
{
    public class PlusDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public BindingList<EMP> Students
        {
            get; set;
        } = new BindingList<EMP>();

        public PlusDataViewModel ()
        {
        }
    }
}
