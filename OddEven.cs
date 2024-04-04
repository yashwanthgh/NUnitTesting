using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class OddEven
    {
         int Number;

        public OddEven(int n)
        {
            Number = n;
        }
        public string IsEven()
        {
            if(Number % 2 == 0)
            {
                return "Even";
            } else
            {
                return "Odd";
            }
        }
    }
}
