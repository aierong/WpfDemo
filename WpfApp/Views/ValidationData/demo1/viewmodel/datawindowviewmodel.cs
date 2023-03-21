using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace WpfApp.Views.ValidationData.demo1.viewmodel
{
    public class datawindowviewmodel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public datawindowviewmodel ()
        {

            Name = "Name_init";

            Title = "init";

            Age = 18;

            ShowCommand = new MyCommand( Show , IsShow );
           
        }


        //public ICommand TestCommand
        //{
        //    get; set;
        //}

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

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );
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

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Title" ) );
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;

                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Age" ) );
            }
        }



        /// <summary>
        /// 命令
        /// </summary>
        public MyCommand ShowCommand
        {
            get; set;
        }

  

        public void Show ()
        {
            Name = "改了";
            Title = "le title";

            MessageBox.Show( "show Command" );
        }



        public bool IsShow ()
        {
            if ( !string.IsNullOrEmpty( Error ) )
            {
                return false;
            }

            return  true;
        }



        public bool IsShowButton
        {
            get
            {
                return string.IsNullOrWhiteSpace( Error );
            }
        }



        private string error;

        public string Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;

                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Error" ) );
            }
        }





        public string this[string name]
        {
            get
            {
                string result = null;

                if ( name == "Age" )
                {
                    if ( this.age < 0 || this.age > 150 )
                    {
                        result = "Age(年龄) 必须 not be less than 0 or greater than 150.";
                    }

                }

                if ( name == "Title" )
                {
                    if ( !String.IsNullOrEmpty( this.title ) )
                    {
                        if ( this.title.Length > 20 )
                        {
                            result = "title 长度大于10";
                        }

                    }
                    else
                    {
                        result = "title必须填写";
                    }

                }

                Error = result;
                //IsShow();
                //ShowCommand.CanExecuteChanged(this,null);
                ShowCommand.CanExecute( Error );
                return result;
            }
        }
    }
}
