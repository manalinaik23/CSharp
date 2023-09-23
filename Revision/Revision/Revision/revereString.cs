using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class revereString
    {
        public void reverseText(string src)
        {
            string newString = "";
            for(int i = src.Length - 1; i >= 0; i--)
            {
                newString += src[i];
            }

            Console.WriteLine("Reverse String: "+newString);
        }
    }
}
