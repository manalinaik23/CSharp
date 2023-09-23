using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class PrimeNumber
    {
        public void isPrimeNumber(int num)
        {
            int m = num / 2;
            int flag = 0;
            for(int i = 2; i <= m; i++)
            {
                if(num % i ==0)
                {
                    flag = 1;

                }

            }

            if(flag == 0)
            {
                Console.WriteLine(num+"is Prime number");
            }
            else
            {
                Console.WriteLine(num+"is not prime number");
            }

        }
    }
}
