using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunction
{
    public class ReverseString
    {
       public string reverseStringValue(string stringValue)
        {
            string ans = "";
            for(int i = stringValue.Length - 1; i >= 0; i--)
            {
                ans += stringValue[i] + "";
            }
            
            return ans.Trim();
        }
    }
}
