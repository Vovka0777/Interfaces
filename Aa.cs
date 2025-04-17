using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_6
{
    internal class Aa : A
    {
        int z;

        public int Z { get => z; set => z = value; }

        public Aa(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
        }
        public override int Plus()
        {
            return X + Y;
        }

        public override int Minus()
        {
            return X - Y;
        }

        public override double Mul()
        {
            return X * Y;
        }

        public override double Div()
        {
            return X / Y;
        }
    }
}
