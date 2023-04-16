using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace PrismDemo.DataDemo.VM
{
    public class ModelDataVM : BindableBase
    {
        private string _Title = "init———vm";

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                //SetProperty就是设置值,并且通知属性改变
                SetProperty( ref _Title , value );

                //通知某个属性改变RaisePropertyChanged
                RaisePropertyChanged( "Caption" );
            }
        }

        private string _names = "guoguo";

        public string Names
        {
            get
            {
                return _names;
            }
            set
            {
                SetProperty( ref _names , value );

                //通知某个属性改变RaisePropertyChanged
                RaisePropertyChanged( "Caption" );
            }
        }

        public string Caption
        {
            get
            {
                return string.Format( "Title:{0}-{1}" , Title , Names );
            }
        }

        private bool _IsEnabled = false;

        public bool IsEnabled
        {
            get
            {
                return _IsEnabled;
            }
            set
            {
                SetProperty( ref _IsEnabled , value );

                //通知某个命令
                ButtonClickCommand.RaiseCanExecuteChanged();
                ButtonClickCommandNew.RaiseCanExecuteChanged();
            }
        }


        /// <summary>
        /// 定义命令
        /// </summary>
        public DelegateCommand ButtonClickCommand
        {
            get; private set;
        }





        //下面是另外一种写法,这样写,不用去构造函数中初始化命令
        private DelegateCommand _ButtonClickCommand;
        public DelegateCommand ButtonClickCommandNew => _ButtonClickCommand ?? ( _ButtonClickCommand = new DelegateCommand( Submit , CanSubmit ) );
        //public DelegateCommand ButtonClickCommandNew => _ButtonClickCommand ?? ( _ButtonClickCommand = new DelegateCommand( Submit  ).ObservesCanExecute( () => IsEnabled ) );

        //带参数的
        private DelegateCommand<double> _getCurrentTimeCommand;
        public DelegateCommand<double> GetCurrentTimeCommand => _getCurrentTimeCommand ?? ( _getCurrentTimeCommand = new DelegateCommand<double>( ( double val ) =>
        {
            //一些逻辑

        } , ( double val ) =>
        {
            //一些逻辑
            return true;
        } ) );



        public DelegateCommand ButtonClickCommandTwo
        {
            get; private set;
        }

        /// <summary>
        /// 定义命令(带参数)
        /// </summary>
        public DelegateCommand<double?> ButtonClickParCommand
        {
            get; private set;
        }


        public DelegateCommand AsyncButtonClickCommand
        {
            get; private set;
        }

        public DelegateCommand<double?> AsyncButtonParClickCommand
        {
            get; private set;
        }

        private bool _IsLoadData = false;

        public bool IsLoadData
        {
            get
            {
                return _IsLoadData;
            }
            set
            {
                SetProperty( ref _IsLoadData , value );

                AsyncButtonClickCommand.RaiseCanExecuteChanged();
            }
        }

        private bool _IsLoadParData = false;

        public bool IsLoadParData
        {
            get
            {
                return _IsLoadParData;
            }
            set
            {
                SetProperty( ref _IsLoadParData , value );

                AsyncButtonParClickCommand.RaiseCanExecuteChanged();
            }
        }

        public ModelDataVM ()
        {
            //构造函数中,初始化命令
            ButtonClickCommand = new DelegateCommand( Submit , CanSubmit );

            //这个可以上面一样效果，但是不用IsEnabled通知，简单一些
            ButtonClickCommandTwo = new DelegateCommand( () =>
            {
                Title = "hello(改)";
            } ).ObservesCanExecute( () => IsEnabled );

            ButtonClickParCommand = new DelegateCommand<double?>( ( double? val ) =>
            {
                if ( val != null )
                {
                    Title = $"hello(改):{val}";
                }
            } );

            AsyncButtonClickCommand = new DelegateCommand( AsyncButtonClick , () =>
            {
                return !IsLoadData;
            } );

            AsyncButtonParClickCommand = new DelegateCommand<double?>( AsyncButtonParClick , ( double? val ) =>
            {
                return !IsLoadParData;
            } );
        }

        private bool CanSubmit ()
        {
            return IsEnabled;
        }

        private void Submit ()
        {
            //点击按钮,修改标题
            Title = "hello(改)";
        }

        async void AsyncButtonClick ()
        {
            IsLoadData = true;

            await Task.Delay( 4800 );
            Title = "hello(Task改)";

            IsLoadData = false;
        }

        async void AsyncButtonParClick ( double? val )
        {
            IsLoadParData = true;

            await Task.Delay( 4800 );
            Title = $"hello(Task改):{val}";

            IsLoadParData = false;
        }
    }
}
