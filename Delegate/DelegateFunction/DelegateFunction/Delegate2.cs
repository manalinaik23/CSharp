using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunction
{
    public delegate void customeDelegate(string args);
    public class Delegate2
    {

        public static void display(string Text) {

            StringBuilder stringBuilder = new StringBuilder();

            int start = Text.Length - 1;
            int end = Text.Length - 1;

            while(start > 0)
            {

                if(Text[start] == ' ')
                {
                    int a = start + 1;
                    while (a <= end)
                    {
                        stringBuilder.Append(Text[a]);
                        a++;
                    }
                    stringBuilder.Append(" ");
                    end = start - 1;
                }
                start--;
            }

            for(int i = 0; i <= end; i++)
            {
                stringBuilder.Append(Text[i]);
            }

            Console.WriteLine(stringBuilder);

        }
    }
}
