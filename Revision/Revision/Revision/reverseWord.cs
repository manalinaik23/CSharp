using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class reverseWord
    {
        public void reverseSentence(string src)
        {
            StringBuilder reverstring = new StringBuilder();
            int start = src.Length - 1;
            int end = src.Length - 1;
            int i = 0;
            while(start > 0)
            {
                if(src[start] == ' ')
                {
                    i = start + 1;
                    while (i <= end)
                    {
                        reverstring.Append(src[i]);
                        i++;
                    }
                    reverstring.Append(' ');
                    end = start - 1;


                }
                start--;
            }

            for(int k = 0; k <= end; k++)
            {
                reverstring.Append(src[k]);
            }

            Console.WriteLine("Reverse Word :"+ reverstring);
        }
    }
}
