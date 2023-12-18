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
    public class DataGridUserControl1VM : ObservableObject
    {
        public ObservableCollection<DataClass> DataList
        {
            get; set;
        } = new ObservableCollection<DataClass>();

        public DataGridUserControl1VM ()
        {
            //初始化
            DataList = new ObservableCollection<DataClass>() {
                 new DataClass
            {
                Header = "Atomic",
                Content = "1.jpg",
                Footer = "Stive Morgan"
            },
            new DataClass
            {
                Header = "Zinderlong",
                Content = "2.jpg",
                Footer = "Zonderling"
            },
            new DataClass
            {
                Header = "Busy Doin' Nothin'",
                Content = "3.jpg",
                Footer = "Ace Wilder"
            },
            //new DataClass
            //{
            //    Header = "Wrong",
            //    Content = "4.jpg",
            //    Footer = "Blaxy Girls"
            //},
            //new DataClass
            //{
            //    Header = "The Lights",
            //    Content = "5.jpg",
            //    Footer = "Panda Eyes"
            //},



            };




        }
    }
}
