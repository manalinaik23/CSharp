using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MethodOverloading
    {
        public int add(int a, int b)
        {
            return (a + b);
        }

        public int add(int a ,int b, int c)
        {
            return (a + b + c);
        }

        public float add(float a, float b)
        {
            return (a + b);
        }

        public string add(string a, string b)
        {
            return (a + " " + b);
        }
    }
}
