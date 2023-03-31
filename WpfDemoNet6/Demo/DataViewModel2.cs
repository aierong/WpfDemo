using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

/*
这里演示自动生成属性和命令

1.继承ObservableObject 并且类标记是分部类partial
2.私有变量标记属性 [ObservableProperty]
3.NotifyCanExecuteChangedFor  通知依赖命令
  NotifyPropertyChangedFor    通知依赖属性
4.RelayCommand  定义命令
5.OnPropertyChanged 手动通知属性更新
6.ButtonClickCommand.NotifyCanExecuteChanged() 手动通知命令更新
7.OnLastNameChanging OnLastNameChanged  某个属性改变
8.OnPropertyChanged  所有属性改变
*/

namespace WpfDemoNet6.Demo
{
    public partial class DataViewModel2 : ObservableObject
    {
        /*
        [ObservableProperty]标记后,会自动生成属性(大写命名),例如:下面会自动生成Title

        注意:这个私有变量命名:必须是小写开头,或者下划线,或者m_
        */

        /*
        NotifyPropertyChangedFor 通知依赖属性Caption
        */

        [ObservableProperty]
        [NotifyPropertyChangedFor( nameof( Caption ) )]
        private string title = "hello";

        //public string Title
        //{
        //    get
        //    {
        //        return title;
        //    }
        //    set
        //    {
        //        //title = value;
        //        //PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( "Name" ) );

        //        //SetProperty 相当与设置值,并且PropertyChanged通知调用
        //        SetProperty( ref title , value );
        //    }
        //}


        /*
                [NotifyCanExecuteChangedFor( nameof( ButtonClickCommand ) )]
        NotifyCanExecuteChangedFor是通知依赖命令(触发命令),相当于set中ButtonClickCommand.NotifyCanExecuteChanged();
        */

        [ObservableProperty]
        [NotifyCanExecuteChangedFor( nameof( ButtonClickCommand ) )]
        private bool isEnabled = false;

        //public bool IsEnabled
        //{
        //    get => isEnabled;
        //    set
        //    {
        //        SetProperty( ref isEnabled , value );

        //        //通知命令 已经改变
        //        ButtonClickCommand.NotifyCanExecuteChanged();
        //    }
        //}

        //partial void OnIsEnabledChanged ( bool value )
        //{
        //     //如果上面的[NotifyCanExecuteChangedFor( nameof( ButtonClickCommand ) )]不写，可以这里手动通知更新 
        //    //ButtonClickCommand.NotifyCanExecuteChanged();
        //}




        /*
        RelayCommand是定义命令,自动生成的命令名是方法名+Command,并且初始化
        例如:下面的会自动生成ButtonClickCommand

        CanExecute是指定一个判断方法,判断是否可用
        */

        [RelayCommand( CanExecute = nameof( CanButton ) )]
        void ButtonClick ()
        {
            //点击按钮,修改标题
            Title = "hello(改)";
        }

        bool CanButton ()
        {
            return IsEnabled;
        }

        //public RelayCommand ButtonClickCommand
        //{
        //    get;
        //}



        public DataViewModel2 ()
        {
            //RelayCommand的第一个参数是命令调用语句
            //              第2个参数(可选)是否允许使用
            //ButtonClickCommand = new RelayCommand( () =>
            //{
            //    //点击按钮,修改标题
            //    Title = "hello(改)";
            //} , () =>
            //{
            //    return IsEnabled;
            //} );

            //ButtonClickParCommand = new RelayCommand<double>( ( double val ) =>
            //{
            //    Title = $"hello(改):{val}";
            //} );
        }



        [RelayCommand]
        void ButtonClickPar ( double val )
        {
            Title = $"hello(改):{val}";

            //DataWindow1 dlg = new DataWindow1();
            //////dlg.Show ();
            //dlg.ShowDialog();
        }

        //public RelayCommand<double> ButtonClickParCommand
        //{
        //    get;
        //}



        [RelayCommand]
        async Task AsyncButtonClick ()
        {
            await Task.Delay( 4800 );
            Title = "hello(Task改)";
        }



        [RelayCommand]
        async Task AsyncButtonParClick ( double val )
        {
            await Task.Delay( 4800 );
            Title = $"hello(Task改):{val}";
        }



        public string Caption
        {
            get
            {
                return string.Format( "Title:{0}-{1}" , Title , LastName );
            }
        }


        [ObservableProperty]
        [NotifyPropertyChangedFor( nameof( Caption ) )]
        private string lastName = "abc";

        /*
        还可以实现2个方法：OnLastNameChanging OnLastNameChanged (注意2个方法只可以实现其中一个,或者都不实现(不能同时2个))
        */

        //partial void OnLastNameChanging ( string value )
        //{
        //    Debug.WriteLine( value );
        //}

        partial void OnLastNameChanged ( string value )
        {
            // 可以做一些其它事情 例如：属性改变后，消息通知某某某
            Debug.WriteLine( value );



            //说明：如果上面[NotifyPropertyChangedFor( nameof( Caption ) )]不写，可以这里手动通知属性更新
            //OnPropertyChanged( nameof( Caption ) );
        }



        /// <summary>
        /// 所有属性改变
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPropertyChanged ( PropertyChangedEventArgs e )
        {

            base.OnPropertyChanged( e );

            // 可以获取到是哪个属性改变了
            var _proname = e.PropertyName;
        }




    }
}
