using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunction
{
     class PrimeNumber
    {
        int isPrimeflag = 0;
        public void IsPrimeFunction(int number)
        {
            int m = number / 2;
            for(int i = 2; i <= m; i++)
            {
                if(number%i == 0)
                { 
                    
                    isPrimeflag = 1;
                   
                }
            }
            if(isPrimeflag == 0)
            {
                Console.WriteLine(number + " number is prime");
            }
            else
            {
                Console.WriteLine(number + " number is not prime");
            }
        }
    }
}
