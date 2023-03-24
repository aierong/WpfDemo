using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoNet6.IOCDemo.Service.Service
{
    public class BillService : IBill
    {
        readonly IOCDemo.Service.Repository.IBill _IRepositoryBill;


        public BillService ( IOCDemo.Service.Repository.IBill iRepositoryBill )
        {
            this._IRepositoryBill = iRepositoryBill;
        }

        public string GetData ( string name )
        {
            //return string.Format( "name:{0}" , name );
            return _IRepositoryBill.GetData ( name );
        }

        public bool IsExistId ( string name )
        {
            //return name == "qq";
            return _IRepositoryBill.IsExistId ( name );
        }
    }
}
