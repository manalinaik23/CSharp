using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
     class Program
    {
        public static void display1990to94(IEnumerator<int> o){
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current);
                if (Convert.ToInt32(o.Current) > 2000)
                {
                    display2000to2003((o));
                }
                
               
            }
        }
        public static void display2000to2003(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current);
            }
        }
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1990);
            oyears.Add(1991);
            oyears.Add(1992);
            oyears.Add(1993);
            oyears.Add(1994);
            oyears.Add(2000);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);

            IEnumerable<int> ienum = (IEnumerable<int>)oyears;

            //foreach(var a in ienum){
            //    Console.WriteLine(a);
            //}

            Console.WriteLine("-------------------------------------");
            IEnumerator<int> enumerator = oyears.GetEnumerator();
            Program.display1990to94(enumerator);
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}


            Console.ReadLine();

        }
    }
}
