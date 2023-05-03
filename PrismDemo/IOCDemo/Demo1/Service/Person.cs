using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo.IOCDemo.Demo1.Service
{

    public interface IPerson
    {
        string Sex
        {
            get;
        }

        string Name
        {
            get; set;
        }
    }


    public class Man : IPerson
    {
        public string Sex => "男";

        public string Name
        {
            get; set;
        }
    }


    public class Woman : IPerson
    {
        public string Sex => "女";

        public string Name
        {
            get; set;
        }
    }
}
