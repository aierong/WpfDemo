using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyOrgDemo.Models;




namespace HandyOrgDemo.ViewModels.UserControls
{
    public partial class CardUserControlVM : ObservableObject
    {
        public ObservableCollection<CardModel> Students
        {
            get; set;
        } = new ObservableCollection<CardModel>();


        public ObservableCollection<CardModel> StudentsDT
        {
            get; set;
        } = new ObservableCollection<CardModel>();

        public CardUserControlVM ()
        {
            //初始化
            Students = new ObservableCollection<CardModel>() {
                 new CardModel
            {
                Header = "Atomic",
                Content = "1.jpg",
                Footer = "Stive Morgan"
            },
            new CardModel
            {
                Header = "Zinderlong",
                Content = "2.jpg",
                Footer = "Zonderling"
            },
            new CardModel
            {
                Header = "Busy Doin' Nothin'",
                Content = "3.jpg",
                Footer = "Ace Wilder"
            },
            new CardModel
            {
                Header = "Wrong",
                Content = "4.jpg",
                Footer = "Blaxy Girls"
            },
            new CardModel
            {
                Header = "The Lights",
                Content = "5.jpg",
                Footer = "Panda Eyes"
            },
             new CardModel
            {
                Header = "EA7-50-Cent Disco",
                Content = "6.jpg",
                Footer = "еяхат музыка"
            },
            new CardModel
            {
                Header = "Monsters",
                Content = "7.jpg",
                Footer = "Different Heaven"
            },
            new CardModel
            {
                Header = "Gangsta Walk",
                Content = "8.jpg",
                Footer = "Illusionize"
            },

            };


            StudentsDT = new ObservableCollection<CardModel>() {
                 new CardModel
            {
                Header = "Atomic",
                Content = "1.jpg",
                Footer = "Stive Morgan"
            },
              new CardModel
            {
                Header = "Zinderlong",
                Content = "2.jpg",
                Footer = "Zonderling"
            },






            };

        }



        [RelayCommand]
        void Update ()
        {
            Students.Clear();

            Students.Add( new CardModel
            {
                Header = "EA7-50-Cent Disco" ,
                Content = "6.jpg" ,
                Footer = "еяхат музыка"
            } );

            Students.Add( new CardModel
            {
                Header = "Monsters" ,
                Content = "7.jpg" ,
                Footer = "Different Heaven"
            } );

            StudentsDT.Clear();
            StudentsDT.Add( new CardModel
            {
                Header = "EA7-50-Cent Disco" ,
                Content = "6.jpg" ,
                Footer = "еяхат музыка"
            } );

            StudentsDT.Add( new CardModel
            {
                Header = "Monsters" ,
                Content = "7.jpg" ,
                Footer = "Different Heaven"
            } );
            StudentsDT.Add( new CardModel
            {
                Header = "Zinderlong" ,
                Content = "2.jpg" ,
                Footer = "Zonderling"
            } );

        }



    }
}
