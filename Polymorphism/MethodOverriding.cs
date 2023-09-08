using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MethodOverriding
    {
        public virtual int add(int a , int b)
        {
            return (a + b);
        }
    }

    public class MethodOverridingChild : MethodOverriding
    {
        public override int add(int a, int b)
        {
           if(a < 0 || b < 0)
            {
                Console.WriteLine("Enter number 1");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Number 2");
                b = int.Parse(Console.ReadLine());



            }

            return (a + b);
        }
    }
}
