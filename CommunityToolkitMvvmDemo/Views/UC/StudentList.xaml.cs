using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommunityToolkitMvvmDemo.ViewModels.UC;

namespace CommunityToolkitMvvmDemo.Views.UC
{
    /// <summary>
    /// StudentList.xaml 的互動邏輯
    /// </summary>
    public partial class StudentList : UserControl
    {
        public StudentList ()
        {
            InitializeComponent();

            this.DataContext = new StudentListViewModel();
        }
    }
}
