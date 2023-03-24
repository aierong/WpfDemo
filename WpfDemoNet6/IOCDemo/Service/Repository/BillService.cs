using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoNet6.IOCDemo.Service.Repository
{
    public class BillService : IBill
    {
        public string GetData ( string name )
        {
            return string.Format( "name:{0}" , name );
        }

        public bool IsExistId ( string name )
        {
            return name == "qq";
        }
    }
}
