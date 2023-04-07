using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Views.KJ.Base;

namespace WpfApp.Views.KJ.Tab
{
    public partial class TabViewModel : INotifyPropertyChanged
    {



        public event PropertyChangedEventHandler PropertyChanged;

        public TabViewModel ()
        {
            UserSelectIndex = 1;

            UpdateNextCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "UpdateImgCommand:" );

                UserSelectIndex = UserSelectIndex >= 2 ? 0 : UserSelectIndex + 1;
            } );

            GetIndexCommand = new MyCommand( () =>
            {
                Debug.WriteLine( "UpdateImgCommand:" );

                MessageBox.Show( UserSelectIndex.ToString() );
            } );
        }


        private int userSelectIndex = 1;

        /// <summary>
        /// 名字
        /// </summary>
        public int UserSelectIndex
        {
            get
            {
                return userSelectIndex;
            }
            set
            {
                userSelectIndex = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "UserSelectIndex" ) );
            }
        }

        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand UpdateNextCommand
        {
            get; set;
        }

        public MyCommand GetIndexCommand
        {
            get; set;
        }
    }
}
