using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_6
{
    internal class Ab : A, IArifmetic2
    {
        public double Pow()
        {
            return Math.Pow(X, X);
        }

        public double Sqrt()
        {
            return Math.Sqrt(X);
        }

        public Ab(int x, int y) : base(x, y)
        {
        }
    }
}
