using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo.IOCDemo.Demo1.Service.Repository
{
    public class BillService : IBill
    {
        public string GetData ( string name )
        {
            return string.Format( "name:{0} 现在时间:{1}" , name , DateTime.Now.ToLongTimeString() );
        }

        public bool IsExistId ( string name )
        {
            return name == "qq";
        }
    }
}
