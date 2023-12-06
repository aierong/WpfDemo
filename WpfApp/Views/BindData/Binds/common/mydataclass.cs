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

        public static string title = "wo de title";

        public const string constr1 = "title(常量)";
    }

}
