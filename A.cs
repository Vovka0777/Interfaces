using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_6
{
    internal class A:IArifmetic1
    {
        int x;
        int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public A(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual int Plus()
        {
            return x + y;
        }
        public virtual int Minus()
        {
            return x - y;
        }
        public virtual double Mul()
        {
            return x * y;
        }
        public virtual double Div()
        {
            if (y == 0)
            {
                Console.WriteLine("Деление на 0 невозможно");
            }
            return x / y;
        }
        public void Show()
        {
            Console.WriteLine($"x = {X}, y = {Y}");
        }
    }
}
