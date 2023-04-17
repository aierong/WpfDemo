using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo.IOCDemo.Demo1.Service.Repository
{
    public interface IBill
    {
        bool IsExistId ( string name );

        string GetData ( string name );
    }
}
