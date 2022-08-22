using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Methods
{
    public class OverloadingMethod
    {
        public int Compute(int a, int b)
        {
            return a + b;
        }
        public int Compute(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Compute(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}
