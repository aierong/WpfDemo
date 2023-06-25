using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp.Views.KJ.grid.tiaojianxianshi.Models;

namespace WpfApp.Views.KJ.grid.tiaojianxianshi.Selector
{
    public  class StudentAgeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ChengRenTemplate
        {
            get; set;
        }

        public DataTemplate NotChengRenTemplate
        {
            get; set;
        }


        public override DataTemplate SelectTemplate ( object item , DependencyObject container )
        {
            var model = item as StudentDataNew;

            if ( model != null )
            {
                return model.IsChengRen ? ChengRenTemplate : NotChengRenTemplate;
            }

            else
            {
                return null;
            }
        }

    }
}
