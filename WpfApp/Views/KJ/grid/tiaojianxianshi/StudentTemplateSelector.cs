﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Views.KJ.grid.tiaojianxianshi
{
    public class StudentTemplateSelector : DataTemplateSelector
    {

        /* 思路:
        1.定义一个类继承:DataTemplateSelector
        2.根据逻辑定义多个DataTemplate变量
        3.override方法SelectTemplate,根据条件返回不同DataTemplate变量
        */
        public DataTemplate NanTemplate
        {
            get; set;
        }

        public DataTemplate NvTemplate
        {
            get; set;
        }

        public override DataTemplate SelectTemplate ( object item , DependencyObject container )
        {
            var model = item as StudentDataNew;

            if ( model != null )
            {
                return model.IsMan ? NanTemplate : NvTemplate;
            }

            else
            {
                return null;
            }
        }
    }
}
