using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using HandyOrgDemo.Models;

namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class UserControlCarouselVM : ObservableObject
    {
        public ObservableCollection<string> Images
        {
            get; set;
        } = new ObservableCollection<string>();

        public UserControlCarouselVM ()
        {
            Images = new ObservableCollection<string>() {
                "/assets/Image/lb/2.jpg" ,
                "/assets/Image/lb/1.jpg" ,
                "/assets/Image/lb/3.jpg"
            };
        }
    }
}
