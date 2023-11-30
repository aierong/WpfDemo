using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp.Views.KJ.grid.tiaojianxianshi.Models;

namespace WpfApp.Views.KJ.DongTai.Selector
{
    public class TypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate JinTianTemplate
        {
            get; set;
        }

        public DataTemplate ZuoTianTemplate
        {
            get; set;
        }

        public DataTemplate MingTianTemplate
        {
            get; set;
        }



        public override DataTemplate SelectTemplate ( object item , DependencyObject container )
        {
            var num = Convert.ToInt32( item );
            //根据条件返回3种不同类型模版
            return num == 1 ? JinTianTemplate : ( num == 2 ? MingTianTemplate : ZuoTianTemplate );
        }
    }
}
