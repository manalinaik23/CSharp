using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class SubString
    {
        public void findAllSubString(string src)
        {
            for(int i = 0; i < src.Length - 1; i++)
            {
                StringBuilder substring = new StringBuilder(src.Length-i);

                for(int j = i; j < src.Length - 1; j++)
                {
                    substring.Append(src[j]);
                    Console.WriteLine(substring+" ");
                }

            }
        }
    }
}
