using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

//1.实现接口 INotifyDataErrorInfo

namespace WpfApp.Views.ValidationData.demo1.viewmodel
{
    public class datawindowviewmodel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public datawindowviewmodel ()
        {

            Name = "guoguo";

            Title = "init";

            Age = 18;

            SaveCommand = new MysCommand( SaveData , () =>
            {
                return !HasErrors;
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
                //if ( value.Length < 5 )
                //{
                //    AddError( nameof( Name ) , "名字不可以小于5" );
                //}
                //else
                //{
                //    DeleteError( nameof( Name ) );
                //}

                name = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );

                //OnErrorChanged( nameof( Name ) );

                this.ValidateProperty<string>( value , nameof( Name ) );
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
                //if ( value.Length < 10 )
                //{
                //    AddError( nameof( Title ) , "长度不可以小于10" );
                //}
                //else
                //{
                //    DeleteError( nameof( Title ) );
                //}

                //if ( !value.StartsWith( "abc" ) )
                //{
                //    AddError( nameof( Title ) , "标题必须abc开头" );
                //}
                //else
                //{
                //    DeleteError( nameof( Title ) );
                //}

                title = value;

                //通知数据已经变化
                PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Title" ) );

                //OnErrorChanged( nameof( Title ) );

                this.ValidateProperty<string>( value , nameof( Title ) );
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

                this.ValidateProperty<int>( value , nameof( Age ) );
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
            if ( HasErrors )
            {
                MessageBox.Show( "有错误呀" );

                return;
            }

            MessageBox.Show( "show Command" );
        }













        /*
        接口的说明:

        public interface INotifyDataErrorInfo
        {
            //是否还存在异常信息
            bool HasErrors { get; }

            //ErrorsChanged就是UI进行异常信息展示
            event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

            //获取一组验证信息， 多个 ValidationAttribute验证后返回来的信息，提供给Validation 使用，对应Validation.ErrorsBing会在绑定的控件上生成 附加属性Validation.Errors，保存验证信息。
            IEnumerable GetErrors(string propertyName);
        }
        */

        /// <summary>
        /// ErrorsChanged就是UI进行异常信息展示
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        /// <summary>
        /// 是否还存在异常信息
        /// </summary>
        public bool HasErrors => ErrorData.Any();

        /// <summary>
        /// 获取一组验证信息
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable GetErrors ( string propertyName )
        {
            //有就返回错误,没有就返回空列表
            if ( ErrorData.ContainsKey( propertyName ) )
            {
                return ErrorData[propertyName];
            }
            else
            {
                return new List<string>() { };
            }
        }

        //我们定义一个集合存放错误信息

        /// <summary>
        /// 集合存放错误信息
        /// </summary>
        private readonly Dictionary<string , List<string>> ErrorData = new Dictionary<string , List<string>>() { };


        /// <summary>
        /// 错误信息加入列表
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="errorMessage"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void AddError ( string propertyName , string errorMessage )
        {
            if ( !ErrorData.ContainsKey( propertyName ) )
            {
                ErrorData.Add( propertyName , new List<string> { errorMessage } );
            }
        }

        /// <summary>
        /// 错误信息从列表中删除
        /// </summary>
        /// <param name="propertyName"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void DeleteError ( string propertyName )
        {
            if ( ErrorData.ContainsKey( propertyName ) )
            {
                //存在就删除
                ErrorData.Remove( propertyName );
            }
        }

        /// <summary>
        /// 通知发生错误
        /// </summary>
        /// <param name="propertyName"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void OnErrorChanged ( string propertyName )
        {
            ErrorsChanged?.Invoke( this , new DataErrorsChangedEventArgs( propertyName ) );
        }




        void ValidateProperty<T> ( T val , [CallerMemberName] string propertyName = "" )
        {
            if ( ErrorData.ContainsKey( propertyName ) )
            {
                //存在就删除
                ErrorData.Remove( propertyName );
            }


            //下面一个个属性写判断逻辑

            if ( propertyName == "Title" )
            {
                //判断逻辑写这里
                string value = val.ToString();

                if ( value.Length < 10 )
                {
                    AddError( propertyName , "长度不可以小于10" );
                }
                else
                {
                    if ( !value.StartsWith( "abc" ) )
                    {
                        AddError( propertyName , "标题必须abc开头" );
                    }
                }
            }

            if ( propertyName == "Age" )
            {
                int value = int.Parse( val.ToString() );

                if ( value < 18 )
                {
                    AddError( propertyName , "年龄必须大于18" );
                }
                else
                {
                    if ( value > 250 )
                    {
                        AddError( propertyName , "年龄必须小于250" );
                    }
                }
            }

            if ( propertyName == "Name" )
            {
                string value = val.ToString();

                if ( value.Length < 5 )
                {
                    AddError( propertyName , "名字不可以小于5" );
                }
            }

            //通知一下，错误信息
            ErrorsChanged?.Invoke( this , new DataErrorsChangedEventArgs( propertyName ) );

            return;
        }



    }
}
