using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CalcBindDemo
{




    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel ()
        {

        }

        [ObservableProperty]
        private string title = "hello";

        [ObservableProperty]
        private string name = "cheng";


        [ObservableProperty]
        private string last = "guo";

        [ObservableProperty]
        private int a = 1;

        [ObservableProperty]
        private int b = 2;

        [ObservableProperty]
        private int c = 3;

        [ObservableProperty]
        private bool isChecked = false;

        [ObservableProperty]
        private bool isFull = false;

        [ObservableProperty]
        private DisplayType playType = DisplayType.All;

        [RelayCommand()]
        void ButtonClick ()
        {
            //点击按钮,修改标题
            A = A + 1;
            B = B + 2;
            C = C + 3;

            IsChecked = !IsChecked;
            IsFull = !IsFull;

            Name = Name + "C";
            Last = Last + "L";
            Title = Title + "Ti";

            PlayType = PlayType == DisplayType.All ? DisplayType.Up : DisplayType.All;
        }
    }






    public enum DisplayType
    {
        All = 10,
        Up = 20,
        Down = 30
    }



}
