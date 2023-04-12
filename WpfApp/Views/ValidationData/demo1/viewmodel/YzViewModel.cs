using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace WpfApp.Views.ValidationData.demo1.viewmodel
{
    public class YzViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public YzViewModel ()
        {
            Name = "guoguo";

            Title = "init";

            Age = 18;

            SaveCommand = new MysCommand( SaveData , () =>
            {
                return !ErrorData.Any();
            } );

        }



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
        public MysCommand SaveCommand
        {
            get; set;
        }



        void SaveData ()
        {
            if ( ErrorData.Any() )
            {
                MessageBox.Show( "有错误呀" );

                return;
            }

            MessageBox.Show( "OK" );
        }


        public string Error
        {
            get
            {
                //这个没有啥用，返回null
                return null;
            }
        }



        public string this[string name]
        {
            get
            {
                string result = null;


                //下面一个个属性写判断逻辑
                if ( name == "Title" )
                {
                    //判断逻辑写这里
                    string value = this.Title;

                    if ( value.Length < 10 )
                    {
                        result = "长度不可以小于10";
                    }
                    else
                    {
                        if ( !value.StartsWith( "abc" ) )
                        {
                            result = "标题必须abc开头";
                        }
                    }
                }

                if ( name == "Name" )
                {
                    string value = this.Name;

                    if ( value.Length < 5 )
                    {
                        result = "名字长度不可以小于5";
                    }
                }

                if ( name == "Age" )
                {
                    int value = this.Age;

                    if ( value < 18 )
                    {
                        result = "年龄必须大于18";
                    }
                    else
                    {
                        if ( value > 250 )
                        {
                            result = "年龄必须小于250";
                        }
                    }
                }



                //先删除再说
                ErrorData.Remove( name );

                if ( !string.IsNullOrEmpty( result ) )
                {
                    ErrorData.Add( name , result );
                }

                return result;
            }
        }

        /// <summary>
        /// 集合存放错误信息
        /// </summary>
        private readonly Dictionary<string , string> ErrorData = new Dictionary<string , string>() { };





    }
}
