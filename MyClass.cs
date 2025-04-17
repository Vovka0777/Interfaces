using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_2
{
    internal class MyClass : IInterface
    {
        public double Pi()
        {
            return Math.PI;
        }
        public int Num()
        {
            return 4;
        }
        public double Sqr()
        {
            return Math.Pow(Num(), 2);
        }
        public double Sqrt()
        {
            return Math.Sqrt(Num());
        }
    }
}
