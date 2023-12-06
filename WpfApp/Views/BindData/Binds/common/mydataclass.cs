using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Views.BindData.Binds.common
{
    public class mydataclass
    {
        public string StrName
        {
            get; set;
        } = "我是公有的";

        public static string title = "标题";

        public const string constr1 = "常量来了";
    }

}
