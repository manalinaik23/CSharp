using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunction
{
    public delegate void addValueDelegateFunction(string name);
    public class DelegateClass
    {
        public static void addValues(string value)
        {
            Console.WriteLine(value);
        }
    }
}
