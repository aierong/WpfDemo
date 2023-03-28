using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Views.BindData.ListData.plus.Models;


namespace WpfApp.Views.BindData.ListData.plus.ViewModels
{
    public class PlusDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public BindingList<EMP> Students
        {
            get; set;
        } = new BindingList<EMP>();

        public PlusDataViewModel ()
        {
            //初始化
            Students = new BindingList<EMP>() {
                new EMP(){ Id=10, Age=11, Name="Tom"},
                new EMP(){ Id=20, Age=12, Name="Darren"},
                new EMP(){ Id=30, Age=13, Name="Jacky"},
                new EMP(){ Id=40, Age=14, Name="Andy"}
            };



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


        public CZCommand UpdateCommand
        {
            get; set;
        }


        public CZCommand AllUpdateCommand
        {
            get; set;
        }


        public CZCommand UpdateOneCommand
        {
            get; set;
        }


        /// <summary>
        /// 总计
        /// </summary>
        public int Total
        {
            get => Students != null & Students.Count > 0 ? Students.Sum( item => item.Age ) : 0;

        }


    }
}
