using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.BindData.contexts.basedemo
{
    public class DataViewModel2 : ViewModelBase
    {
        private string name;

        /// <summary>
        /// 名字
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

                OnPropertyChanged("Name");
            }
        }

        private string title;


        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get => title;

            set
            {
                title = value;

                OnPropertyChanged( "Title" );
            }
        }
    }
}
