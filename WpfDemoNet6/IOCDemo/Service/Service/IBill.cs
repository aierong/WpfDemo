using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoNet6.IOCDemo.Service.Service
{
    public interface IBill
    {
        bool IsExistId ( string name );

        string  GetData ( string name );
    }
}
