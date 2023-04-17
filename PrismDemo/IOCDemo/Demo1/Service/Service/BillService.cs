using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo.IOCDemo.Demo1.Service.Service
{
    public class BillService : IBill
    {
        readonly IOCDemo.Demo1.Service.Repository.IBill _IRepositoryBill;


        public BillService ( IOCDemo.Demo1.Service.Repository.IBill iRepositoryBill )
        {
            this._IRepositoryBill = iRepositoryBill;
        }

        public string GetData ( string name )
        {
        
            return _IRepositoryBill.GetData ( name );
        }

        
    }
}
