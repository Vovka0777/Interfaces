using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A(10,12);
            Console.WriteLine("obj1: ");
            obj1.Show();
            Console.WriteLine(obj1.Plus());
            Console.WriteLine(obj1.Minus());

            Ab obj2 = new Ab(4,16);
            Console.WriteLine("obj2: ");
            obj2.Show();
            Console.WriteLine(obj2.Pow());
            Console.WriteLine(obj2.Sqrt());

            Console.Read();
        }
    }
}
