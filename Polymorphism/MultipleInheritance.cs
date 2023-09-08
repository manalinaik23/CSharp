using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MultipleInheritance : Interface1, Interface2
    {
        void Interface1.add()
        {
            Console.WriteLine("Calling Interface 1 method ");
        }

        void Interface2.add()
        {
            Console.WriteLine("Calling Interface 2 method ");
        }

       /* public void add()
        {
            Console.WriteLine("interface");
        }*/

      
    }
}
